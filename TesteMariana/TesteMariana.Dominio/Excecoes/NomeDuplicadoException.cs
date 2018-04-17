using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TesteMariana.Dominio
{
    public class NomeDuplicadoException : ApplicationException
    {
        public NomeDuplicadoException() : base("Este nome já foi cadastrado!")
        {
        }

        public NomeDuplicadoException(string message) : base(message)
        {
        }

        public NomeDuplicadoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NomeDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
