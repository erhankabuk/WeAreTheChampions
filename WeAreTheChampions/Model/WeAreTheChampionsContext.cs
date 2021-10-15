using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{
    public class WeAreTheChampionsContext :DbContext
    {
        public WeAreTheChampionsContext():base("name=WeAreTheChampionsContext")
        {
                
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Player>().Property(x => x.PlayerName).HasMaxLength(50);
        //} fluentApı araştır.
        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamColor> TeamColors { get; set; }

    }
}
