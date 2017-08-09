using Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService;
using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
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
    [ExceptionsHandler]
    public class ChampionshipController : ApiController
    {
        private readonly IChampionshipService _championshipService;
        public ChampionshipController(IChampionshipService championshipService)
        {
            if (championshipService == null)
                throw new NotHandlerException(Resources.ErrorMessages.IOCNoCreatedObject);
            _championshipService = championshipService;
        }

        public async Task<IHttpActionResult> CreateChampionship([FromBody] ChampionshipDto championshipDto)
        {
            await _championshipService.CreateChampionship(championshipDto);
            return Ok();
        } 
    }
}
