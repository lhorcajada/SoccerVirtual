using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService
{
    public class MapperChampionship : MapperBase<ChampionshipDto, Championship>
    {
        public override List<Championship> MappingFromDtoListToEntityList(List<ChampionshipDto> dtoList)
        {
            throw new NotImplementedException();
        }

        public override Championship MappingFromDtoToEntity(ChampionshipDto dto)
        {
            return new Championship
            {
                AppUserId = dto.AppUserId,
                Budget = dto.Budget,
                ChampionshipTypeName = dto.ChampionshipType?.Name,
                DiscountBudgetTeamValue = dto.DiscountBudgetTeamValue,
                InitialPlayers = dto.InitialPlayers,
                IsPrivate = dto.IsPrivate,
                LeagueName = dto.League?.Name,
                Name = dto.Name,
                PointSystemName = dto.PointSystem?.Name
                
            };
        }

        public override List<ChampionshipDto> MappingFromEntityListToDtoList(List<Championship> entityList)
        {
            throw new NotImplementedException();
        }

        public override ChampionshipDto MappingFromEntityToDto(Championship entity)
        {
            throw new NotImplementedException();
        }
    }
}