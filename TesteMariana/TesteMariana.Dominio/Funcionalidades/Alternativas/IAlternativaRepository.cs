using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMariana.Dominio.Base;

namespace TesteMariana.Dominio.Funcionalidades.Alternativas
{
    public interface IAlternativaRepository : IRepository<Alternativa>
    {
        bool Existe(string resposta);
    }
}
