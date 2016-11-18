using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RuinAndReefWithMigrations.Models
{
    public class RuinAndReefDbContext : DbContext
        //Ruin&ReefDbContext extends DbContext
    {
        //Each DbSet will become a table in the database.
        public DbSet<Location> Locations { get; set; }
        public DbSet<Experience> Experiences { get; set; }

 
        public RuinAndReefDbContext(DbContextOptions<RuinAndReefDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
            
    }
}

//next add Entity Framework to Startup.cs