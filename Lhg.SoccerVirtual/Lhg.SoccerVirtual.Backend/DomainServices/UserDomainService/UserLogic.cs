using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lhg.SoccerVirtual.Backend.Models;

namespace Lhg.SoccerVirtual.Backend.DomainServices.UserDomainService
{
    public class UserLogic : IUserLogic
    {
        public ApplicationUser GetUserData()
        {
            return new ApplicationUser
            {
                Id = 1,
                Alias = "Prueba",
                LastName = "Apellido",
                Name = "Nombre",
                Password = "1234567890"
            };
        }
    }
}