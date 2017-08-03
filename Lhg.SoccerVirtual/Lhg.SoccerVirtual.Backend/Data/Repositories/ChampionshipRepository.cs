using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using Lhg.SoccerVirtual.Backend.Models;
using Lhg.SoccerVirtual.Backend.Models.ExternalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Data.Repositories
{
    public class ChampionshipRepository : RepositoryBase<Championship>, IChampionshipRepository
    {
        public ChampionshipRepository(IDataFactory dataFactory) : 
            base(dataFactory)
        {
        }
    }
}