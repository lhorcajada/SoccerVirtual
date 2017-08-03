using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.AppServices
{
    public abstract class MapperBase<TDto,TEntity>
    {
        public abstract TEntity MappingFromDtoToEntity( TDto dto);
        public abstract List<TEntity> MappingFromDtoListToEntityList(List<TDto> dtoList);
        public abstract TDto MappingFromEntityToDto(TEntity entity);
        public abstract List<TDto> MappingFromEntityListToDtoList(List<TEntity> entityList);
    }
}