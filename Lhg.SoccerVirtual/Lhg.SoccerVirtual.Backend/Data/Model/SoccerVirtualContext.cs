namespace Lhg.SoccerVirtual.Backend.Data.Model
{
    using Models;
    using Models.ExternalData;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SoccerVirtualContext : DbContext
    {
        public SoccerVirtualContext()
            : base("name=SoccerVirtualContext")
        {
        }

        public virtual DbSet<Championship> Championships { get; set; }
    }

   
}