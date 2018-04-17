using System;
using System.Collections.Generic;
using TesteMariana.Dominio;
using TesteMariana.Dominio.Excecoes;
using TesteMariana.Dominio.Funcionalidades.Materias;

namespace TesteMariana.Aplicacao
{
    public class MateriaService
    {
        private IMateriaRepository _materiaRepository;

        public MateriaService(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        public void Adiciona(Materia materia)
        {
            materia.Valida();

            var materiaEncontrada = _materiaRepository.Existe(materia.Nome);

            if (materiaEncontrada)
                throw new NomeDuplicadoException();

            _materiaRepository.Adicionar(materia);
        }

        public void Editar(Materia materia)
        {
            materia.Valida();

            var materiaEncontrada = _materiaRepository.Existe(materia.Nome);

            if (materiaEncontrada)
                throw new NomeDuplicadoException();

            _materiaRepository.Editar(materia);
        }

        public Materia SelecionaPorId(int id)
        {
            return _materiaRepository.SelecionaPorId(id);
        }

        public IList<Materia> SelecionaTudo()
        {
            return _materiaRepository.SelecionaTudo();
        }

        public void Deletar(Materia materia)
        {
            if (RegistroComDependecia(materia.Id))
                throw new DependenciaException();

            _materiaRepository.Deletar(materia.Id);
        }

        private bool RegistroComDependecia(int id)
        {
            return _materiaRepository.RegistroComDependecia(id);
        }
    }
}