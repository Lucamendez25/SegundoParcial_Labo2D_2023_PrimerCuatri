using System.Runtime.Serialization;

namespace PrimerParcialLaboratorio2023
{
    [Serializable]
    internal class NoTieneDineroSuficienteException : Exception
    {
        public NoTieneDineroSuficienteException()
        {
        }

        public NoTieneDineroSuficienteException(string? message) : base(message)
        {
        }

        public NoTieneDineroSuficienteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoTieneDineroSuficienteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}