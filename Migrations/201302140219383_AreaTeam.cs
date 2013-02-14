namespace SponsorAnAFSer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AreaTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentWidgets", "AreaTeam", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentWidgets", "AreaTeam");
        }
    }
}
