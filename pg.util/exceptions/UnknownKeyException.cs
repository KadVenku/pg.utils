using System;
using System.Runtime.Serialization;

namespace pg.util.exceptions
{
    public class UnknownKeyException : Exception
    {
        public UnknownKeyException()
        {
        }

        public UnknownKeyException(string message) : base(message)
        {
        }

        public UnknownKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}