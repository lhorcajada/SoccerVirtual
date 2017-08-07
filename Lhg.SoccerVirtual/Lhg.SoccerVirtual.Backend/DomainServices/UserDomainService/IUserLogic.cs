using Lhg.SoccerVirtual.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.DomainServices.UserDomainService
{
    public interface IUserLogic
    {
        ApplicationUser GetUserData();
    }
}
