using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio.Funcionalidades.Disciplinas
{
    public interface IDisciplinaRepository : IRepository<Disciplina>
    {
        bool Existe(string nome);

        bool RegistroComDependencia(int id);
    }
}