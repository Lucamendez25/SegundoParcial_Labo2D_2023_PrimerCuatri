using System.Runtime.Serialization;

namespace PrimerParcialLaboratorio2023
{
    [Serializable]
    internal class NoHayStockException : Exception
    {
        public NoHayStockException()
        {
        }

        public NoHayStockException(string? message) : base(message)
        {
        }

        public NoHayStockException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoHayStockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}