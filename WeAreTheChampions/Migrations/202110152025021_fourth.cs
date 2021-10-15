namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "Team1Id" });
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            AlterColumn("dbo.Matches", "Team1Id", c => c.Int());
            AlterColumn("dbo.Matches", "Team2Id", c => c.Int());
            CreateIndex("dbo.Matches", "Team1Id");
            CreateIndex("dbo.Matches", "Team2Id");
            AddForeignKey("dbo.Matches", "Team1Id", "dbo.Teams", "Id");
            AddForeignKey("dbo.Matches", "Team2Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Matches", "Team1Id", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "Team2Id" });
            DropIndex("dbo.Matches", new[] { "Team1Id" });
            AlterColumn("dbo.Matches", "Team2Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Matches", "Team1Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Matches", "Team2Id");
            CreateIndex("dbo.Matches", "Team1Id");
            AddForeignKey("dbo.Matches", "Team2Id", "dbo.Teams", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Matches", "Team1Id", "dbo.Teams", "Id", cascadeDelete: true);
        }
    }
}
