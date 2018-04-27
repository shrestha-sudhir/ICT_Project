namespace ICT_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyDatas",
                c => new
                    {
                        DailyDataID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        WorkingSDC = c.Int(nullable: false),
                        Appointments = c.Int(nullable: false),
                        Presentations = c.Int(nullable: false),
                        SuccessfulPresentations = c.Int(nullable: false),
                        Attendance = c.Int(nullable: false),
                        Members = c.Int(nullable: false),
                        NinthKyus = c.Int(nullable: false),
                        Classes = c.Int(nullable: false),
                        EquipmentSales = c.Single(nullable: false),
                        Interviews = c.Int(nullable: false),
                        RegionalID = c.Int(nullable: false),
                        ZoneID = c.Int(nullable: false),
                        SdcNightly_SdcNightID = c.Int(),
                    })
                .PrimaryKey(t => t.DailyDataID)
                .ForeignKey("dbo.SdcNightlies", t => t.SdcNightly_SdcNightID)
                .Index(t => t.SdcNightly_SdcNightID);
            
            CreateTable(
                "dbo.Internationals",
                c => new
                    {
                        InternationalID = c.Int(nullable: false, identity: true),
                        Continent = c.String(),
                    })
                .PrimaryKey(t => t.InternationalID);
            
            CreateTable(
                "dbo.Zones",
                c => new
                    {
                        ZoneID = c.Int(nullable: false, identity: true),
                        ZoneName = c.String(),
                        ZoneDirector = c.String(),
                        ZoneGoal = c.String(),
                        InternationalID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZoneID)
                .ForeignKey("dbo.Internationals", t => t.InternationalID, cascadeDelete: true)
                .Index(t => t.InternationalID);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        RegionalID = c.Int(nullable: false, identity: true),
                        RegionName = c.String(),
                        RegionManager = c.String(),
                        ZoneID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegionalID)
                .ForeignKey("dbo.Zones", t => t.ZoneID, cascadeDelete: true)
                .Index(t => t.ZoneID);
            
            CreateTable(
                "dbo.SdcDetails",
                c => new
                    {
                        SdcDetailsID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        IsTeamCoordinator = c.String(),
                        IsFullTime = c.Int(nullable: false),
                        SdcSequenceNum = c.Int(nullable: false),
                        RegionID = c.Int(nullable: false),
                        Region_RegionalID = c.Int(),
                    })
                .PrimaryKey(t => t.SdcDetailsID)
                .ForeignKey("dbo.Regions", t => t.Region_RegionalID)
                .Index(t => t.Region_RegionalID);
            
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        NoticesID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Message = c.String(),
                        RegionID = c.Int(nullable: false),
                        Region_RegionalID = c.Int(),
                    })
                .PrimaryKey(t => t.NoticesID)
                .ForeignKey("dbo.Regions", t => t.Region_RegionalID)
                .Index(t => t.Region_RegionalID);
            
            CreateTable(
                "dbo.PDTopics",
                c => new
                    {
                        PDTopicsID = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        RegionID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Region_RegionalID = c.Int(),
                    })
                .PrimaryKey(t => t.PDTopicsID)
                .ForeignKey("dbo.Regions", t => t.Region_RegionalID)
                .Index(t => t.Region_RegionalID);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionsID = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                        PositionLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PositionsID);
            
            CreateTable(
                "dbo.SdcNightlies",
                c => new
                    {
                        SdcNightID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SdcNightID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        RememberMe = c.String(),
                        Inactive = c.String(),
                        PhoneNum = c.Int(nullable: false),
                        PositionID = c.Int(nullable: false),
                        Positions_PositionsID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Positions", t => t.Positions_PositionsID)
                .Index(t => t.Positions_PositionsID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Positions_PositionsID", "dbo.Positions");
            DropForeignKey("dbo.DailyDatas", "SdcNightly_SdcNightID", "dbo.SdcNightlies");
            DropForeignKey("dbo.PDTopics", "Region_RegionalID", "dbo.Regions");
            DropForeignKey("dbo.Notices", "Region_RegionalID", "dbo.Regions");
            DropForeignKey("dbo.Regions", "ZoneID", "dbo.Zones");
            DropForeignKey("dbo.SdcDetails", "Region_RegionalID", "dbo.Regions");
            DropForeignKey("dbo.Zones", "InternationalID", "dbo.Internationals");
            DropIndex("dbo.Users", new[] { "Positions_PositionsID" });
            DropIndex("dbo.PDTopics", new[] { "Region_RegionalID" });
            DropIndex("dbo.Notices", new[] { "Region_RegionalID" });
            DropIndex("dbo.SdcDetails", new[] { "Region_RegionalID" });
            DropIndex("dbo.Regions", new[] { "ZoneID" });
            DropIndex("dbo.Zones", new[] { "InternationalID" });
            DropIndex("dbo.DailyDatas", new[] { "SdcNightly_SdcNightID" });
            DropTable("dbo.Users");
            DropTable("dbo.SdcNightlies");
            DropTable("dbo.Positions");
            DropTable("dbo.PDTopics");
            DropTable("dbo.Notices");
            DropTable("dbo.SdcDetails");
            DropTable("dbo.Regions");
            DropTable("dbo.Zones");
            DropTable("dbo.Internationals");
            DropTable("dbo.DailyDatas");
        }
    }
}
