using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Exceptions
{
    public class NotHandlerException : Exception
    {
        public NotHandlerException()
        {
        }

        public NotHandlerException(string message) : base(message)
        {
        }

        public NotHandlerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotHandlerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}