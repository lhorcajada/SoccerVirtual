using Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService;
using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using Lhg.SoccerVirtual.Backend.DomainServices.LeagueDomainService;
using Lhg.SoccerVirtual.Backend.Models.League;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.AppServices.LeagueAppService
{
    public class LeagueService:ILeagueService
    {
        private readonly ILeagueLogic _leagueLogic;

        public LeagueService(ILeagueLogic leagueLogic)
        {
            _leagueLogic = leagueLogic;
        }
        public List<ILeague> GetLeagueAll()
        {
            return _leagueLogic.CreateLeagueList();
  

        }
    }
}