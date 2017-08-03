using Lhg.SoccerVirtual.Backend.AppServices.ChampionshipTypeAppService;
using Lhg.SoccerVirtual.Backend.Exceptions;
using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lhg.SoccerVirtual.Backend.Controllers
{
    public class ChampionshipTypeController : ApiController
    {
        private readonly IChampionshipTypeService _championshipTypeService;
        public ChampionshipTypeController(IChampionshipTypeService championshipTypeService)
        {
            if (championshipTypeService == null)
                throw new NotHandlerException(Resources.ErrorMessages.IOCNoCreatedObject);
            _championshipTypeService = championshipTypeService;
        }

        public List<IChampionshipType> GetChampionshipTypes()
        {
           return _championshipTypeService.GetChampionshipTypeAll();
        }
    }
}
