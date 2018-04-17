using System;
using System.Collections.Generic;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Alternativas;
using TesteMariana.Dominio.Funcionalidades.Questoes;

namespace TesteMariana.Aplicacao
{
    public class QuestaoService
    {
        private IQuestaoRepository _questaoRepository;

        private IAlternativaRepository _alternativaRepository;

        public QuestaoService(IQuestaoRepository questaoRepository, IAlternativaRepository alternativaRepository)
        {
            _questaoRepository = questaoRepository;
            _alternativaRepository = alternativaRepository;
        }

        public void Adicionar(Questao questao)
        {
            questao.Valida();

            _questaoRepository.Adicionar(questao);

            foreach (var alternativa in questao.Alternativas)
            {
                alternativa.Valida();
                _alternativaRepository.Adicionar(alternativa);
            }
        }

        public void Deletar(Questao questaoSelecionada)
        {
            throw new NotImplementedException();
        }

        public IList<Questao> SelecionaTodas()
        {
            return new List<Questao>();
        }
    }
}