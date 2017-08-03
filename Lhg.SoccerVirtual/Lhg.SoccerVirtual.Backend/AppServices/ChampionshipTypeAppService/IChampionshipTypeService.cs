using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.AppServices.ChampionshipTypeAppService
{
    public interface IChampionshipTypeService
    {
        List<IChampionshipType> GetChampionshipTypeAll();
    }
}
