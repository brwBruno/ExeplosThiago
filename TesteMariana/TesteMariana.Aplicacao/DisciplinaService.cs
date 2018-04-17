using System;
using System.Collections.Generic;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Excecoes;
using TesteMariana.Dominio.Funcionalidades.Disciplinas;

namespace TesteMariana.Aplicacao
{
    public class DisciplinaService
    {
        private IDisciplinaRepository _disciplinaRepostory;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepostory = disciplinaRepository;
        }

        public void Adicionar(Disciplina novaDisciplina)
        {
            novaDisciplina.Valida();

            bool disciplinaEncontrada = _disciplinaRepostory.Existe(novaDisciplina.Nome);

            if (disciplinaEncontrada)
                throw new NomeDuplicadoException();

            _disciplinaRepostory.Adicionar(novaDisciplina);
        }

        public void Editar(Disciplina disciplinaEditada)
        {
            disciplinaEditada.Valida();

            bool disciplinaEncontrada = _disciplinaRepostory.Existe(disciplinaEditada.Nome);

            if (disciplinaEncontrada)
                throw new NomeDuplicadoException();

            _disciplinaRepostory.Editar(disciplinaEditada);
        }

        public void Deletar(Disciplina disciplinaDeletada)
        {
            if (RegistroComDependecia(disciplinaDeletada.Id))
                throw new DependenciaException();

            _disciplinaRepostory.Deletar(disciplinaDeletada.Id);
        }

        private bool RegistroComDependecia(int id)
        {
           return  _disciplinaRepostory.RegistroComDependencia(id);
        }

        public Disciplina SelecionaPorId(int id)
        {
            return _disciplinaRepostory.SelecionaPorId(id);
        }

        public List<Disciplina> SelecionaTudo()
        {
            return _disciplinaRepostory.SelecionaTudo();
        }
    }
}