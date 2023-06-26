using System.Runtime.Serialization;

namespace SegundoParcialLaboratorio
{
    [Serializable]
    internal class NoLlenoTodosLosCamposException : Exception
    {
        public NoLlenoTodosLosCamposException() : base("No lleno todos los campos")
        {
        }

        public NoLlenoTodosLosCamposException(string? message) : base(message)
        {
        }

        public NoLlenoTodosLosCamposException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NoLlenoTodosLosCamposException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}