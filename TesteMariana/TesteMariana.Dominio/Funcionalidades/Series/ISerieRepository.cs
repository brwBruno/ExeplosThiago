using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio.Funcionalidades.Series
{
    public interface ISerieRepository : IRepository<Serie>
    {
        bool Existe(string descricao);

        bool RegistroComDependecia(int id);
    }
}