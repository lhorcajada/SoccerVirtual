using Lhg.SoccerVirtual.Backend.Models.League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.DomainServices.LeagueDomainService
{
    public class LeagueLogic : ILeagueLogic
    {
        public List<ILeague> CreateLeagueList()
        {
            List<ILeague> leagueList = new List<ILeague>
            {
                new FirstDivisionSpanish
                {
                    Id =1,
                    Name = Resources.ErrorMessages.LeagueSpanishName
                },
             
            };
            return leagueList;
        }
    }
}