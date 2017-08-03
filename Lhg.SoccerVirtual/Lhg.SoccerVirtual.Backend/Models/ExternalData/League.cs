using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAnnotation = System.ComponentModel.DataAnnotations;

namespace Lhg.SoccerVirtual.Backend.Models.ExternalData
{
    public class League
    {
        [DataAnnotation.Key]
        public int Id { get; internal set; }
        public string Name { get; internal set; }
    }
}