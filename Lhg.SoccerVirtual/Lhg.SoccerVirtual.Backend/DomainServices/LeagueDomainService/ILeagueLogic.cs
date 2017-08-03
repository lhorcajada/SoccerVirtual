using Lhg.SoccerVirtual.Backend.Models.League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.DomainServices.LeagueDomainService
{
    public interface ILeagueLogic
    {
        List<ILeague> CreateLeagueList();

    }
}
