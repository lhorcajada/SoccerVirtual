using Lhg.SoccerVirtual.Backend.DomainServices.ChampionshipTypeDomainService;
using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.AppServices.ChampionshipTypeAppService
{
    public class ChampionshipTypeService:IChampionshipTypeService
    {
        private readonly IChampionshipTypeLogic _championshipTypeLogic;
        public ChampionshipTypeService(IChampionshipTypeLogic championshipTypeLogic)
        {
            if (championshipTypeLogic == null)
                _championshipTypeLogic = championshipTypeLogic;
        }
        public List<IChampionshipType> GetChampionshipTypeAll()
        {
           return _championshipTypeLogic.CreateChampionshipTypeList();
        }
    }
}