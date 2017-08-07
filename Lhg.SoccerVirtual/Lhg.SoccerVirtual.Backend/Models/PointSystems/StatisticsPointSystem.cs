using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Models.PointSystems
{
    public class StatisticsPointSystem:IPointSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}