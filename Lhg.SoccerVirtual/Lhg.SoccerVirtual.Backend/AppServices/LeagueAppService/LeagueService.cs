using Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService;
using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
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
        private readonly ILeagueRepository _leagueRepository;

        public LeagueService(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
        }
        public async Task<List<LeagueDto>> GetLeagueAll()
        {
            var leagueList = await _leagueRepository.GetAll()
                 .ToListAsync();
            MapperLeague mapper = new MapperLeague();
            return mapper.MappingFromEntityListToDtoList(leagueList);

        }
    }
}