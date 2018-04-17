using System;
using System.Text.RegularExpressions;
using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio
{
    public class Materia : Entidade
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public Serie Serie { get; set; }

        public Materia()
        {
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} : {2} - {3}", Id, Nome, Disciplina.Nome, Serie.Descricao);
        }

        public override void Valida()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new InvalidOperationException("O nome da matéria é obrigatório!");

            if (Nome.Length < 4)
                throw new InvalidOperationException("O nome da matéria deve ter mais que 4 caracteres!");

            if (Disciplina == null)
                throw new InvalidOperationException("A matéria deve ter uma disciplina!");

            if (Serie == null)
                throw new InvalidOperationException("A matéria deve ter uma série!");

            if (Nome.Length > 30)
                throw new InvalidOperationException("O nome da matéria deve ser menor que 30 caracteres!");

            if (!Regex.IsMatch(Nome.ToLower(), @"^[a-z-A-Z_á-úçãõâêôà\s]+$"))
                throw new InvalidOperationException("O nome da matéria não pode conter caractres especiais ou números!");
        }
    }
}