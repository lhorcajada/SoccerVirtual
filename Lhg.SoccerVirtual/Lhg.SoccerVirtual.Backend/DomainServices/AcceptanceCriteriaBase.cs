using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lhg.SoccerVirtual.Backend.Models;

namespace Lhg.SoccerVirtual.Backend.DomainServices
{
    public abstract class AcceptanceCriteriaBase<T> : IAcceptanceCriteria<T>
    {
        public virtual void CriteriaToCreate(ApplicationUser user, T championshipToCreate) { }
  
    }
}