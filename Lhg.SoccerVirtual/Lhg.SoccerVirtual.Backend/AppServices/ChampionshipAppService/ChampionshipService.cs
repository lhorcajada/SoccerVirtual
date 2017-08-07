using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.DomainServices.DataContracts;
using System.Data.Entity;
using Lhg.SoccerVirtual.Backend.DomainServices.ChampionshipService;
using Lhg.SoccerVirtual.Backend.DomainServices.UserDomainService;
using Lhg.SoccerVirtual.Backend.Models;
using Lhg.SoccerVirtual.Backend.Exceptions;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using Lhg.SoccerVirtual.Backend.AppServices.Shared;

namespace Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService
{
    public class ChampionshipService:IChampionshipService
    {
        private readonly IUserLogic _userLogic;
        private readonly IChampionshipRepository _championshipRepository;
        private readonly IUnitOfWork _uow;
        public ChampionshipService(IUserLogic userLogic,
            IChampionshipRepository championshipRepository, IUnitOfWork uow)
        {
            _userLogic = userLogic;
            _championshipRepository = championshipRepository;
            _uow = uow;
        }

        public async Task CreateChampionship(ChampionshipDto championshipDto)
        {
            var user = _userLogic.GetUserData();
            var championshipToCreate = new MapperChampionship().MappingFromDtoToEntity(championshipDto);
            _championshipRepository.Add(championshipToCreate);
            await CommitAsync.SetCommitAsync(_uow);

        }


   
    }
}