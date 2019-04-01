using CharCreator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterCreator.DAL
{
    public class SiteInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<SiteContext>
    {
        protected override void Seed(SiteContext context)
        {
            var players = new List<Player>
            {
                new Player{Name="Justin Blain" +
                "bridge", Age=35, ExperienceLevel =ExperienceLevel.Intermediate, Location= "Indianapolis"},
                new Player{Name="Anastasia Trobridge", Age=18, ExperienceLevel =ExperienceLevel.Beginner, Location= "Indianapolis"},
                new Player{Name="Sara Blainbridge", Age=36, ExperienceLevel =ExperienceLevel.Novice, Location= "Indianapolis"},
                new Player{Name="Jordan Blain", Age=34, ExperienceLevel =ExperienceLevel.Beginner, Location= "Chicago"},
                new Player{Name="Jake Hugo", Age=35, ExperienceLevel =ExperienceLevel.Advanced, Location= "Saginaw"}
            };

            players.ForEach(s => context.Players.Add(s));
            context.SaveChanges();

            var characters = new List<Character>
            {
                new Character{CharName="Glentificus", Alignment= Alignment.LawfulGood, Background= Background.Acolyte, CharHistory= "Something", ExperiencePoints= 0, Level= 1, Traits="Some"},
                new Character{CharName="Mannie", Alignment= Alignment.LawfulEvil, Background= Background.CriminalSpy, CharHistory= "Something", ExperiencePoints= 0, Level= 1, Traits="Some"},
                new Character{CharName="Sage", Alignment= Alignment.LawfulNeutral, Background= Background.FolkHero, CharHistory= "Something", ExperiencePoints= 0, Level= 1, Traits="Some"},
                new Character{CharName="Rosemary", Alignment= Alignment.TrueNeutral, Background= Background.Noble, CharHistory= "Something", ExperiencePoints= 0, Level= 1, Traits="Some"},
                new Character{CharName="Thyme", Alignment= Alignment.ChaoticGood, Background= Background.Soldier, CharHistory= "Something", ExperiencePoints= 0, Level= 1, Traits="Some"},
            };

            characters.ForEach(s => context.Characters.Add(s));
            context.SaveChanges();

            var stories = new List<Story>
            {
                new Story{StoryName= "First"},
                new Story{StoryName= "Second"},
                new Story{StoryName= "Third"}
            };

            stories.ForEach(s => context.Stories.Add(s));
            context.SaveChanges();
        }
    }
}