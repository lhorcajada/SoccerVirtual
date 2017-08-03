using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes
{
    public class ClassicChampionship : IChampionshipType
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}