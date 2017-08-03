using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.AppServices.LeagueAppService
{
    public interface ILeagueService
    {
        Task<List<LeagueDto>> GetLeagueAll();
    }
}