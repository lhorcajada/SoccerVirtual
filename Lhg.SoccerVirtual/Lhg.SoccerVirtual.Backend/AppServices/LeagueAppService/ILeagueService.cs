using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.Models.League;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.AppServices.LeagueAppService
{
    public interface ILeagueService
    {
        List<ILeague> GetLeagueAll();
    }
}