using System;
using System.Runtime.Serialization;

namespace GerenciadorContatos.Aplicacao.Excecoes
{
    [Serializable]
    public class GerenciadorContatosException : Exception
    {
        public GerenciadorContatosException()
        {
        }

        public GerenciadorContatosException(string message) : base(message)
        {
        }

        public GerenciadorContatosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GerenciadorContatosException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}
