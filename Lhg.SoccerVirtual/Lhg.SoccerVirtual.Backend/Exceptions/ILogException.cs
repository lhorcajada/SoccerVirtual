using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.Exceptions
{
    public interface ILogException
    {
        void RegisterException(Exception exception, string comments);
    }
}
