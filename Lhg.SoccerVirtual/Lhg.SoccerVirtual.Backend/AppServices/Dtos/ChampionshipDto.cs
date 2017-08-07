using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;
using Lhg.SoccerVirtual.Backend.Models.League;
using Lhg.SoccerVirtual.Backend.Models.PointSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.AppServices.Dtos
{
    public class ChampionshipDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public int InitialPlayers { get; set; }
        public bool DiscountBudgetTeamValue { get; set; }
        public bool IsPrivate { get; set; }
        public IChampionshipType ChampionshipType { get; set; }
        public IPointSystem PointSystem { get; set; }
        public ILeague League { get; set; }
        public int AppUserId { get; set; }

    }
}