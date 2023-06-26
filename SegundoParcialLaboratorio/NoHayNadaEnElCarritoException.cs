using System.Runtime.Serialization;

namespace PrimerParcialLaboratorio2023
{
    [Serializable]
    internal class NoHayNadaEnElCarritoException : Exception
    {
        public NoHayNadaEnElCarritoException()
        {
        }

        public NoHayNadaEnElCarritoException(string? message) : base(message)
        {
        }

        public NoHayNadaEnElCarritoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoHayNadaEnElCarritoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}