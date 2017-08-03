using Lhg.SoccerVirtual.Backend.AppServices.Dtos;
using Lhg.SoccerVirtual.Backend.Models.ExternalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.AppServices.ChampionshipAppService
{
    public class MapperLeague : MapperBase<LeagueDto, League>
    {
        public override List<League> MappingFromDtoListToEntityList(List<LeagueDto> dtoList)
        {
            throw new NotImplementedException();
        }

        public override League MappingFromDtoToEntity(LeagueDto dto)
        {
            throw new NotImplementedException();
        }

        public override List<LeagueDto> MappingFromEntityListToDtoList(List<League> entityList)
        {
            List<LeagueDto> dtoList = new List<LeagueDto>();
            foreach(var itemEntity in entityList)
            {
                LeagueDto dto = new LeagueDto
                {
                    ImageUrl = itemEntity.ImageUrl,
                    Name = itemEntity.Name
                };
                dtoList.Add(dto);
            }
            return dtoList;
        }

        public override LeagueDto MappingFromEntityToDto(League entity)
        {
            throw new NotImplementedException();
        }
    }
}