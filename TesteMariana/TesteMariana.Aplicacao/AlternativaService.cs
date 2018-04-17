using System.Collections.Generic;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Funcionalidades.Alternativas;

namespace TesteMariana.Aplicacao
{
    public class AlternativaService
    {
        private IAlternativaRepository _alternativaRepository;

        public AlternativaService(IAlternativaRepository alternativaRepository)
        {
            _alternativaRepository = alternativaRepository;
        }

        public void Adiciona(Alternativa alternativa)
        {
            alternativa.Valida();
            _alternativaRepository.Adicionar(alternativa);
        }

        public void Edita(Alternativa alternativa)
        {
            alternativa.Valida();
            _alternativaRepository.Editar(alternativa);
        }

        public void Deleta(Alternativa alternativa)
        {
            _alternativaRepository.Deletar(alternativa.Id);
        }

        public Alternativa SelecionaPorId(int id)
        {
            return _alternativaRepository.SelecionaPorId(id);
        }

        public IList<Alternativa> SelecionaTudo()
        {
            return _alternativaRepository.SelecionaTudo();
        }
    }
}