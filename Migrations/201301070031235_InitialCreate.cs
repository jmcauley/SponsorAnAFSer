namespace SponsorAnAFSer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentWidgets",
                c => new
                    {
                        StudentWidgetId = c.Guid(nullable: false),
                        Name = c.String(),
                        Srn = c.String(),
                        ProgramRefCode = c.String(),
                        DestinationCountry = c.String(),
                        FundraisingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EndDate = c.DateTime(nullable: false),
                        DisplayName = c.String(),
                        BlogUrl = c.String(),
                        EnbabledStatus = c.Int(nullable: false),
                        AmountRaised = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.StudentWidgetId);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        DonationId = c.Guid(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Postal = c.String(),
                        Email = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonationDate = c.DateTime(nullable: false),
                        StudentWidget_StudentWidgetId = c.Guid(),
                    })
                .PrimaryKey(t => t.DonationId)
                .ForeignKey("dbo.StudentWidgets", t => t.StudentWidget_StudentWidgetId)
                .Index(t => t.StudentWidget_StudentWidgetId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Donations", new[] { "StudentWidget_StudentWidgetId" });
            DropForeignKey("dbo.Donations", "StudentWidget_StudentWidgetId", "dbo.StudentWidgets");
            DropTable("dbo.Donations");
            DropTable("dbo.StudentWidgets");
        }
    }
}
