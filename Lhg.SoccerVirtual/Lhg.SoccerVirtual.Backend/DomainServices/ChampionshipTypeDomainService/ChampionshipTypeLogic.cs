using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;

namespace Lhg.SoccerVirtual.Backend.DomainServices.ChampionshipTypeDomainService
{
    public class ChampionshipTypeLogic : IChampionshipTypeLogic
    {
        public List<IChampionshipType> CreateChampionshipTypeList()
        {
            List<IChampionshipType> championshipTypeList = new List<IChampionshipType>
            {
                new ClassicChampionship
                {
                    Id =1,
                    Name = Resources.ErrorMessages.ChampionshipTypeClassicName
                },
                new SocialChampionship
                {
                    Id =2,
                    Name = Resources.ErrorMessages.ChampionshipTypeSocialName
                },
                new ComunioChampionship
                {
                    Id =3,
                    Name = Resources.ErrorMessages.ChampionshipTypeComunioName
                },


            };
            return championshipTypeList;
        }
    }
}