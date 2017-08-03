using Lhg.SoccerVirtual.Backend.Models.ChampionshipTypes;
using Lhg.SoccerVirtual.Backend.Models.ExternalData;
using Lhg.SoccerVirtual.Backend.Models.PointSystems;
using DataAnnotation = System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lhg.SoccerVirtual.Backend.Models
{
    public class Championship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Presupuesto
        /// </summary>
        public decimal Budget { get; set; }
        public int InitialPlayers { get; set; }
        /// <summary>
        /// Descontar valor del equipo del presupuesto
        /// </summary>
        public bool DiscountBudgetTeamValue { get; set; }
        /// <summary>
        /// Campeonato privado o público
        /// </summary>
        public bool IsPrivate { get; set; }
        public IChampionshipType ChampionshipType { get; set; }
        public IPointSystem PointSystem { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
    }
}