namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "MatchDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matches", "MatchDate");
        }
    }
}
