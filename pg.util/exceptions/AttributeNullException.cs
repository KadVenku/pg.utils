using System;
using System.Runtime.Serialization;

namespace pg.util.exceptions
{
    public class AttributeNullException : Exception
    {
        public AttributeNullException()
        {
        }

        public AttributeNullException(string message) : base(message)
        {
        }

        public AttributeNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AttributeNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}