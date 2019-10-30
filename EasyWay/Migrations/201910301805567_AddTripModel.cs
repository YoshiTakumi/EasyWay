namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTripModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Car_Id = c.Int(nullable: false),
                        Driver_Id = c.Int(nullable: false),
                        Package_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id, cascadeDelete: true)
                .ForeignKey("dbo.Drivers", t => t.Driver_Id, cascadeDelete: true)
                .ForeignKey("dbo.Packages", t => t.Package_Id, cascadeDelete: true)
                .Index(t => t.Car_Id)
                .Index(t => t.Driver_Id)
                .Index(t => t.Package_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trips", "Package_Id", "dbo.Packages");
            DropForeignKey("dbo.Trips", "Driver_Id", "dbo.Drivers");
            DropForeignKey("dbo.Trips", "Car_Id", "dbo.Cars");
            DropIndex("dbo.Trips", new[] { "Package_Id" });
            DropIndex("dbo.Trips", new[] { "Driver_Id" });
            DropIndex("dbo.Trips", new[] { "Car_Id" });
            DropTable("dbo.Trips");
        }
    }
}
