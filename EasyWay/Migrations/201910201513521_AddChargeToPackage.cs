namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChargeToPackage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChargeOfPackages",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        ChargeByRegion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Packages", "ChargeOfPackageId", c => c.Byte(nullable: false));
            AddColumn("dbo.Packages", "FinalPrice", c => c.Int(nullable: false));
            CreateIndex("dbo.Packages", "ChargeOfPackageId");
            AddForeignKey("dbo.Packages", "ChargeOfPackageId", "dbo.ChargeOfPackages", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Packages", "ChargeOfPackageId", "dbo.ChargeOfPackages");
            DropIndex("dbo.Packages", new[] { "ChargeOfPackageId" });
            DropColumn("dbo.Packages", "FinalPrice");
            DropColumn("dbo.Packages", "ChargeOfPackageId");
            DropTable("dbo.ChargeOfPackages");
        }
    }
}
