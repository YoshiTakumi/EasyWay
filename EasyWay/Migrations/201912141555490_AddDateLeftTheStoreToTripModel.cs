namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateLeftTheStoreToTripModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "DateLeftTheStore", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "DateLeftTheStore");
        }
    }
}
