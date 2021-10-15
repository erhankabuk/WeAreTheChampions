namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "Result", c => c.Int());
            AddColumn("dbo.Matches", "Team_Id", c => c.Int());
            AlterColumn("dbo.Matches", "MatchTime", c => c.DateTime());
            CreateIndex("dbo.Matches", "Team1Id");
            CreateIndex("dbo.Matches", "Team2Id");
            CreateIndex("dbo.Matches", "Team_Id");
            AddForeignKey("dbo.Matches", "Team_Id", "dbo.Teams", "Id");
            AddForeignKey("dbo.Matches", "Team1Id", "dbo.Teams", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Matches", "Team2Id", "dbo.Teams", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "Team_Id" });
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            DropIndex("dbo.Matches", new[] { "Team1Id" });
            AlterColumn("dbo.Matches", "MatchTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Matches", "Team_Id");
            DropColumn("dbo.Matches", "Result");
        }
    }
}
