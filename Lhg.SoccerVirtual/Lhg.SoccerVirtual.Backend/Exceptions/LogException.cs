using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Exceptions
{
    public class LogException : ILogException
    {
        public LogException()
        {

        }
        public void RegisterException(Exception exception, string comments)
        {
            throw new NotImplementedException();
        }
    }
}