namespace CinemaStar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        ShowTimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.ShowTimeAndDates", t => t.ShowTimeId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.ShowTimeId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TicketPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShowTimeAndDates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShowDate = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "ShowTimeId", "dbo.ShowTimeAndDates");
            DropForeignKey("dbo.Bookings", "MovieId", "dbo.Movies");
            DropIndex("dbo.Bookings", new[] { "ShowTimeId" });
            DropIndex("dbo.Bookings", new[] { "MovieId" });
            DropTable("dbo.ShowTimeAndDates");
            DropTable("dbo.Movies");
            DropTable("dbo.Bookings");
        }
    }
}
