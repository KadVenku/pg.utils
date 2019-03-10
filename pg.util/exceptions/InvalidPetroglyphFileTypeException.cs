using System;
using System.Runtime.Serialization;

namespace pg.util.exceptions
{
    public class InvalidPetroglyphFileTypeException : Exception
    {
        public InvalidPetroglyphFileTypeException()
        {
        }

        public InvalidPetroglyphFileTypeException(string message) : base(message)
        {
        }

        public InvalidPetroglyphFileTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPetroglyphFileTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
