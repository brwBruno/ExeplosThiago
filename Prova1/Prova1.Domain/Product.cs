using System;

namespace Prova1.Domain
{
    public class Product
    {
        /// <summary>
        /// Prorpiedades com seus respectivos getters e setters (Convenção Pascal Casing)
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public double Expense { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime Manufacture { get; set; }
        public DateTime Expiration { get; set; }


        /// <summary>
        /// Atributos que podem ser manipulados pelas propriedades (Convenção Camel Casing)
        /// </summary>
        private double _sale;

        public double Sale
        {
            get
            {
                return _sale;
            }
            set
            {
                _sale = value;
            }
        }           

        /// <summary>
        /// Método construtor
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Retorna uma string customizada do objeto atual
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Id: {0} - Nome: {1} - Disponível: {2}", Id, Name, IsAvailable ? "Sim" : "Não");
        }

        /// <summary>
        /// Retorna o código hash de cada obejto
        /// Código Hash: Valor numérico de comprimento fixo que identifica exclusivamente a dados
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        /// <summary>
        /// Determina se o objeto especificado é igual ao objeto atual
        /// </summary>
        /// <param name="obj">Objeto que será comparado</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            if (product == null)
                return false;
            else
                return Id.Equals(product.Id);
        }

        /// <summary>
        /// Validação dos campos da classe 
        /// Dispara uma Exception com mensagem
        /// </summary>
        public void Validate()
        {
            if (Name.Length < 4 || String.IsNullOrEmpty(Name))
                throw new Exception("Deve ter um nome com mais de 4 caracteres!");
            if (Sale <= 0)
                throw new Exception("Deve ter um preço de venda maior que 0!");
            if (Expense <= 0)
                throw new Exception("Deve ter um preço de compra maior que 0!");
            if (Expense >= Sale)
                throw new Exception("O preço de compra deve ser menor do que o de venda!");
            if (Manufacture >= Expiration)
                throw new Exception("A data de fabricação deve ser menor que a data de váliade!");
        }
    }
}