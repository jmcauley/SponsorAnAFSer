namespace SponsorAnAFSer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentWidgets", "State", c => c.String());
            AddColumn("dbo.StudentWidgets", "EnabledStatus", c => c.Int(nullable: false));
            DropColumn("dbo.StudentWidgets", "EnbabledStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentWidgets", "EnbabledStatus", c => c.Int(nullable: false));
            DropColumn("dbo.StudentWidgets", "EnabledStatus");
            DropColumn("dbo.StudentWidgets", "State");
        }
    }
}
