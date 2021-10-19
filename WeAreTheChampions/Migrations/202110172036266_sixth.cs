namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixth : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TeamColors", new[] { "Color_Id" });
            DropColumn("dbo.TeamColors", "ColorId");
            RenameColumn(table: "dbo.TeamColors", name: "Color_Id", newName: "ColorId");
            AlterColumn("dbo.TeamColors", "ColorId", c => c.Int());
            CreateIndex("dbo.TeamColors", "ColorId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TeamColors", new[] { "ColorId" });
            AlterColumn("dbo.TeamColors", "ColorId", c => c.String());
            RenameColumn(table: "dbo.TeamColors", name: "ColorId", newName: "Color_Id");
            AddColumn("dbo.TeamColors", "ColorId", c => c.String());
            CreateIndex("dbo.TeamColors", "Color_Id");
        }
    }
}
