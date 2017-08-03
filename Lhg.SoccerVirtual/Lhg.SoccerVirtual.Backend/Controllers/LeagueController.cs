using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.AppServices.LeagueAppService;
using Lhg.SoccerVirtual.Backend.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Lhg.SoccerVirtual.Backend.Controllers
{
    public class LeagueController : ApiController
    {
        private readonly ILeagueService _leagueService;
        public LeagueController(ILeagueService leagueService)
        {
            if (leagueService == null)
                throw new NotHandlerException(Resources.ErrorMessages.IOCNoCreatedObject);
            _leagueService = leagueService;

        }
        public async Task<List<LeagueDto>> GetLeagueAll()
        {
            return await _leagueService.GetLeagueAll();
        }
    }
}
