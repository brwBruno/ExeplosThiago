using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TesteMariana.Dominio
{
    public class DescricaoDuplicadaException : ApplicationException
    {
        public DescricaoDuplicadaException() : base("Esta descrição já foi cadastrada!")
        {
        }

        public DescricaoDuplicadaException(string message) : base(message)
        {
        }

        public DescricaoDuplicadaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DescricaoDuplicadaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
