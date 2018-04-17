using System;
using System.Collections.Generic;
using System.Linq;
using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio
{
    public class Questao : Entidade
    {
        public Materia Materia { get; set; }
        public int Bimestre { get; set; }
        public string Enunciado { get; set; }

        private List<Alternativa> _alternativas;

        public List<Alternativa> Alternativas
        {
            get { return _alternativas; }
        }

        public Questao()
        {
            _alternativas = new List<Alternativa>();
            Materia = new Materia();
        }

        public Questao(int id, int qtdAlternativas, Materia m)
        {
            Id = id;            
            _alternativas = new List<Alternativa>(qtdAlternativas);
        }

        public override void Valida()
        {
            if (string.IsNullOrEmpty(Enunciado))
                throw new InvalidOperationException("O enunciado é obrigatório.");

            if (string.IsNullOrEmpty(Bimestre.ToString()))
                throw new InvalidOperationException("Selecione um bimestre.");

            if (Materia == null)
                throw new InvalidOperationException("Selecione uma Matéria");

            if (Alternativas.Count == 0)
                throw new InvalidOperationException("0 Alternativas na lista.");

            if (!ExisteAlternativaCorreta())
                throw new InvalidOperationException("Não há alternativa correta");
        }

        public bool ExisteAlternativaCorreta()
        {
            return Alternativas.Where(x => x.Correta) != null;
        }

        public void AdcicionaAlternativa(Alternativa alternativaSelecionada)
        {
            Alternativas.Add(alternativaSelecionada);
        }

        public void RemoveAlternativa(Alternativa alternativaSelecionada)
        {
            Alternativas.Remove(alternativaSelecionada);
        }
    }
}