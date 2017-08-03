using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Exceptions
{
    public class BusinessException:Exception
    {
        public BusinessException(string message) : 
            base(message)
        {
        }

        public BusinessException(string message, Exception innerException) : 
            base(message, innerException)
        {
        }
    }
}