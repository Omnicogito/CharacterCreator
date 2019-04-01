using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CharCreator.Data;



namespace CharacterCreator.DAL
{
    public class SiteContext: DbContext
    {
        SiteContext(): base("Site Context")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<CharRace> CharRaces { get; set; }
        public DbSet<CharClass> CharClasses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}