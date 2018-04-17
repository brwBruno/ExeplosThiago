using System;

namespace Prova1.Domain
{
    public class Order
    {
        /// <summary>
        /// Prorpiedades com seus respectivos getters e setters (Convenção Pascal Casing)
        /// </summary>
        public int Id { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        /// <summary>
        /// A propriedade total não pode ser modificada, apenas consultada (Cálculo do lucro do produto)
        /// </summary>
        public double Total
        {
            get
            {
                return (Product.Sale - Product.Expense) * Quantity;
            }
        }

        /// <summary>
        /// Retorna uma string customizada do objeto atual
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Id: {0} - {1} comprou {2} {3}.", Id, Customer, Quantity, Product.Name);
        }

        /// <summary>
        /// Método construtor
        /// </summary>
        public Order()
        {
            Product = new Product();
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
            if (Customer.Length < 4 || String.IsNullOrEmpty(Customer))
                throw new Exception("Deve ter um cliente com mais de 4 caracteres!");
            if (Quantity <= 0)
                throw new Exception("Deve ter uma quantidadea maior que 0!");
            if (Product == null)
                throw new Exception("Deve ter um produto!");
        }
    }
}