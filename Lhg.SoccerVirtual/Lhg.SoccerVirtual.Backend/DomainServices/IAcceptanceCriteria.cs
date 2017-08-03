using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lhg.SoccerVirtual.Backend.Models;

namespace Lhg.SoccerVirtual.Backend.DomainServices
{
    public interface IAcceptanceCriteria<T>
    {
        void CriteriaToCreate(ApplicationUser user, T entityToCreate);
    }
}
