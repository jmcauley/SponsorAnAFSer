namespace SponsorAnAFSer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SyncWithWSDefs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentWidgets", "ServiceId", c => c.Guid(nullable: false));
            AddColumn("dbo.StudentWidgets", "FirstName", c => c.String());
            AddColumn("dbo.StudentWidgets", "LastName", c => c.String());
            AddColumn("dbo.StudentWidgets", "City", c => c.String());
            AddColumn("dbo.Donations", "TransactionId", c => c.String());
            AddColumn("dbo.Donations", "FirstName", c => c.String());
            AddColumn("dbo.Donations", "LastName", c => c.String());
            AddColumn("dbo.Donations", "Zip", c => c.String());
            AddColumn("dbo.Donations", "DateOfTransaction", c => c.DateTime(nullable: false));
            DropColumn("dbo.StudentWidgets", "Name");
            DropColumn("dbo.Donations", "Name");
            DropColumn("dbo.Donations", "Postal");
            DropColumn("dbo.Donations", "DonationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Donations", "DonationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Donations", "Postal", c => c.String());
            AddColumn("dbo.Donations", "Name", c => c.String());
            AddColumn("dbo.StudentWidgets", "Name", c => c.String());
            DropColumn("dbo.Donations", "DateOfTransaction");
            DropColumn("dbo.Donations", "Zip");
            DropColumn("dbo.Donations", "LastName");
            DropColumn("dbo.Donations", "FirstName");
            DropColumn("dbo.Donations", "TransactionId");
            DropColumn("dbo.StudentWidgets", "City");
            DropColumn("dbo.StudentWidgets", "LastName");
            DropColumn("dbo.StudentWidgets", "FirstName");
            DropColumn("dbo.StudentWidgets", "ServiceId");
        }
    }
}
