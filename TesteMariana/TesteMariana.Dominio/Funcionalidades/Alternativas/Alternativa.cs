using System;
using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio
{
    public class Alternativa : Entidade
    {
        public string Resposta { get; set; }
        public bool Correta { get; set; }
        public char Letra { get; set; }
        public Questao Questao { get; set; }

        public Alternativa()
        {
            Questao = new Questao();
        }

        public override void Valida()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Letra)))
                throw new InvalidOperationException("Alternativa deve ter Letra!");

            if (string.IsNullOrEmpty(Resposta))
                throw new InvalidOperationException("Alternativa deve ter resposta!");

            if (Resposta.Length > 50)
                throw new InvalidOperationException("Alternativa deve ter resposta que tenha menos de 50 caracteres!");
        }

        public override string ToString()
        {
            return String.Format("Alternativa: \"{0}\"  {1}", Letra, Resposta);
        }
    }
}