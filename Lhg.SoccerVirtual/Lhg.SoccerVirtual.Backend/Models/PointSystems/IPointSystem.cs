using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Models.PointSystems
{
    public interface IPointSystem
    {
        int Id { get; set; }
        string Name { get; set; }

    }
}