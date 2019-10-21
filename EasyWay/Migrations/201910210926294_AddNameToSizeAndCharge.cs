namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToSizeAndCharge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChargeOfPackages", "Name", c => c.String());
            AddColumn("dbo.SizeOfPackages", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SizeOfPackages", "Name");
            DropColumn("dbo.ChargeOfPackages", "Name");
        }
    }
}
