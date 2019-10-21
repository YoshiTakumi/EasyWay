namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePhoneFormatToLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Packages", "Phone", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Packages", "Phone", c => c.Int(nullable: false));
        }
    }
}
