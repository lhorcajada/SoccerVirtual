using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService
{
    public interface IChampionshipService
    {
        Task CreateChampionship(ChampionshipDto championshipDto);
    }
}