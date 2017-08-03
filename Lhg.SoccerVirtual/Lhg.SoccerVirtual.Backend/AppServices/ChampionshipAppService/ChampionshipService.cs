using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using System.Data.Entity;

namespace Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService
{
    public class ChampionshipService:IChampionshipService
    {
        public ChampionshipService()
        {

        }

        public async Task CreateChampionship(ChampionshipDto championshipDto)
        {
            throw new NotImplementedException();
        }

   
    }
}