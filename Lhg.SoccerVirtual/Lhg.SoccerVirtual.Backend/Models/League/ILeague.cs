using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lhg.SoccerVirtual.Backend.Models.League
{
    public interface ILeague
    {
        int Id { get; set; }
        string Name { get; set; }

    }
}
