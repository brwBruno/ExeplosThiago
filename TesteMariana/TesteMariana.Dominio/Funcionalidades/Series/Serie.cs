using System;
using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio
{
    public class Serie : Entidade
    {
        private string _descricao;

        public Serie(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public Serie()
        {
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", Descricao);
        }

        public override void Valida()
        {
            if (String.IsNullOrWhiteSpace(Descricao))
                throw new InvalidOperationException("A série deve ter descrição!");
        }
    }
}