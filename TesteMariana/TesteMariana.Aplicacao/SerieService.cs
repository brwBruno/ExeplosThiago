using System;
using System.Collections.Generic;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Excecoes;
using TesteMariana.Dominio.Funcionalidades.Series;

namespace TesteMariana.Aplicacao
{
    public class SerieService
    {
        private ISerieRepository _serieRepository;

        public SerieService(ISerieRepository serieRepository)
        {
            _serieRepository = serieRepository;
        }

        public void Adicionar(Serie serie)
        {
            serie.Valida();

            var serieEncontrada = _serieRepository.Existe(serie.Descricao);

            if (serieEncontrada)
                throw new DescricaoDuplicadaException();

            _serieRepository.Adicionar(serie);
        }

        public void Editar(Serie serie)
        {
            serie.Valida();

            var serieEncontrada = _serieRepository.Existe(serie.Descricao);

            if (serieEncontrada)
                throw new NomeDuplicadoException();

            _serieRepository.Editar(serie);
        }

        public void Deletar(Serie serie)
        {
            if (RegistroComDependecia(serie.Id))
                throw new DependenciaException();
            _serieRepository.Deletar(serie.Id);
        }

        private bool RegistroComDependecia(int id)
        {
            return _serieRepository.RegistroComDependecia(id);
        }

        public Serie SelecionaPorId(int id)
        {
            return _serieRepository.SelecionaPorId(id);
        }

        public IList<Serie> SelecionaTudo()
        {
            return _serieRepository.SelecionaTudo();
        }
    }
}