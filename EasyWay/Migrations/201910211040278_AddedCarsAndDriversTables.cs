namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCarsAndDriversTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        YearManufactured = c.DateTime(),
                        LicensePlate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Birthdate = c.DateTime(),
                        Phone = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
            DropTable("dbo.Cars");
        }
    }
}
