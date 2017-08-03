using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using Lhg.SoccerVirtual.Backend.Models.ExternalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Data.Repositories
{
    public class LeagueRepository : RepositoryBase<League>, ILeagueRepository
    {
        public LeagueRepository(IDataFactory dataFactory) : 
            base(dataFactory)
        {
        }
    }
}