namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeAreTheChampions.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAreTheChampions.Model.WeAreTheChampionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeAreTheChampions.Model.WeAreTheChampionsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if (context.Teams.Any()) return;

            var team1 = new Team()
            {
                TeamName = "Team1",
                Player = new List<Player>() {
                    new Player() { PlayerName = "Player1" },
                    new Player() { PlayerName = "Player2" },
                    new Player() { PlayerName = "Player3" },
                    new Player() { PlayerName = "Player4" },
                    new Player() { PlayerName = "Player5" }
                },
                TeamColor = new TeamColor() { Colors = new Color() { ColorName = "Color1", Red = 150, Green = 150, Blue = 150 } }


            };




            var team2 = new Team()
            {
                TeamName = "Team2",
                Player = new List<Player>() {
                    new Player() { PlayerName = "Player11" },
                    new Player() { PlayerName = "Player22" },
                    new Player() { PlayerName = "Player33" },
                    new Player() { PlayerName = "Player44" },
                    new Player() { PlayerName = "Player55" }
                },
                TeamColor = new TeamColor() { Colors = new Color() { ColorName = "Color2", Red = 250, Green = 250, Blue = 250 } }


            };

            context.Teams.Add(team1);
            context.Teams.Add(team2);
            context.SaveChanges();
        }
    }
}
