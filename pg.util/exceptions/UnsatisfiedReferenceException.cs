using System;
using System.Runtime.Serialization;

namespace pg.util.exceptions
{
    public class UnsatisfiedReferenceException : Exception
    {
        public UnsatisfiedReferenceException()
        {
        }

        public UnsatisfiedReferenceException(string message) : base(message)
        {
        }

        public UnsatisfiedReferenceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnsatisfiedReferenceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}