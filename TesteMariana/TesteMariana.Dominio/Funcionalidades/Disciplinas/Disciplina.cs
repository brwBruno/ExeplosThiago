using System;
using System.Text.RegularExpressions;
using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio
{
    public class Disciplina : Entidade
    {
        public Disciplina()
        {
        }

        public string Nome { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} ", Id, Nome);
        }

        public override void Valida()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new InvalidOperationException("O nome da disciplina é obrigatório!");

            if (Nome.Length < 4)
                throw new InvalidOperationException("O nome da disciplina deve ter mais que 4 caracteres!");

            if (Nome.Length > 30)
                throw new InvalidOperationException("O nome da disciplina deve ser menor que 30 caracteres!");

            if (!Regex.IsMatch(Nome.ToLower(), @"^[a-z-A-Z_á-úçãõâêôà\s]+$"))
                throw new InvalidOperationException("O nome da disciplina não pode conter caractres especiais ou números!");
        }
    }
}