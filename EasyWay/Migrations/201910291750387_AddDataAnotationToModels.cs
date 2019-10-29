namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnotationToModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "LicensePlate", c => c.String(nullable: false));
            AlterColumn("dbo.Drivers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Drivers", "Birthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Drivers", "Birthdate", c => c.DateTime());
            AlterColumn("dbo.Drivers", "Name", c => c.String());
            AlterColumn("dbo.Cars", "LicensePlate", c => c.String());
            AlterColumn("dbo.Cars", "Brand", c => c.String());
        }
    }
}
