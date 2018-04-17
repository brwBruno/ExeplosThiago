using System;

namespace TesteMariana.Dominio.Excecoes
{
    public class DependenciaException : InvalidOperationException
    {
        public DependenciaException() : base("Esse registro possui depêndecias!")
        {
        }
    }
}