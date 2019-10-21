namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbSetChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Packages", "Sender", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Packages", "Receiver", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Packages", "ReceiverAddress", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Packages", "ReceiverAddress", c => c.String());
            AlterColumn("dbo.Packages", "Receiver", c => c.String());
            AlterColumn("dbo.Packages", "Sender", c => c.String());
        }
    }
}
