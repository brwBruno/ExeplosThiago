using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio.Funcionalidades.Materias
{
    public interface IMateriaRepository : IRepository<Materia>
    {
        bool Existe(string nome);
        bool RegistroComDependecia(int id);
    }
}