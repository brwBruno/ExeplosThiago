using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio.Funcionalidades.Questoes
{
    public interface IQuestaoRepository : IRepository<Questao>
    {
        bool Existe(string enunciado);
    }
}