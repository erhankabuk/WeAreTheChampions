namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "TeamColor_Id", "dbo.TeamColors");
            DropForeignKey("dbo.Teams", "Match_Id", "dbo.Matches");
            DropIndex("dbo.Teams", new[] { "TeamColor_Id" });
            DropIndex("dbo.Teams", new[] { "Match_Id" });
            RenameColumn(table: "dbo.TeamColors", name: "Colors_Id", newName: "Color_Id");
            RenameIndex(table: "dbo.TeamColors", name: "IX_Colors_Id", newName: "IX_Color_Id");
            AlterColumn("dbo.Matches", "MatchTime", c => c.DateTime(nullable: false));
            CreateIndex("dbo.TeamColors", "TeamId");
            AddForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams", "Id", cascadeDelete: true);
            DropColumn("dbo.Teams", "TeamColor_Id");
            DropColumn("dbo.Teams", "Match_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Match_Id", c => c.Int());
            AddColumn("dbo.Teams", "TeamColor_Id", c => c.Int());
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            AlterColumn("dbo.Matches", "MatchTime", c => c.DateTime());
            RenameIndex(table: "dbo.TeamColors", name: "IX_Color_Id", newName: "IX_Colors_Id");
            RenameColumn(table: "dbo.TeamColors", name: "Color_Id", newName: "Colors_Id");
            CreateIndex("dbo.Teams", "Match_Id");
            CreateIndex("dbo.Teams", "TeamColor_Id");
            AddForeignKey("dbo.Teams", "Match_Id", "dbo.Matches", "Id");
            AddForeignKey("dbo.Teams", "TeamColor_Id", "dbo.TeamColors", "Id");
        }
    }
}
