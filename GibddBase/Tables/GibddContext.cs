using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibddBase.Tables
{
    class GibddContext : DbContext
    {
        public GibddContext() : base("DbConnection")
        { }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<AutoOwner> AutoOwners { get;set;}
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Punishment> Punishments { get; set; }
        public DbSet<Violation> Violations { get; set; }
    }
}
