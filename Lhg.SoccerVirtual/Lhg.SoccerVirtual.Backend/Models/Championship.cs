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
        [DataAnnotation.Key]
        public int Id { get; set; }
        [DataAnnotation.MinLength(40, ErrorMessageResourceName = "NameMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(120, ErrorMessageResourceName = "NameMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string Name { get; set; }
        /// <summary>
        /// Presupuesto
        /// </summary>
        [DataAnnotation.Range(0,500000000, ErrorMessageResourceName = "BudgetRangeError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public decimal Budget { get; set; }

        [DataAnnotation.Range(0, 20, ErrorMessageResourceName = "InitialPlayersRangeError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public int InitialPlayers { get; set; }
        /// <summary>
        /// Descontar valor del equipo del presupuesto
        /// </summary>
        public bool DiscountBudgetTeamValue { get; set; }
        /// <summary>
        /// Campeonato privado o público
        /// </summary>
        public bool IsPrivate { get; set; }

        [DataAnnotation.MinLength(5, ErrorMessageResourceName = "NameMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(120, ErrorMessageResourceName = "NameMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string ChampionshipTypeName { get; set; }
        [DataAnnotation.MinLength(5, ErrorMessageResourceName = "NameMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(120, ErrorMessageResourceName = "NameMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string PointSystemName { get; set; }
        [DataAnnotation.MinLength(5, ErrorMessageResourceName = "NameMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(120, ErrorMessageResourceName = "NameMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string LeagueName { get; set; }

        [DataAnnotation.Required]
        public int AppUserId { get; set; }
        public virtual ApplicationUser AppUser { get; set; }
    }
}