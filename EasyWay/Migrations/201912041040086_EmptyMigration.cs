namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Trips", "TripSerialNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "TripSerialNumber", c => c.Long(nullable: false));
        }
    }
}
