namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSizeAndChargeOfPackage : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SizeOfPackages(Id, Weight, Pricing) VALUES(1, 1, 2)");
            Sql("INSERT INTO SizeOfPackages(Id, Weight, Pricing) VALUES(2, 3, 4)");
            Sql("INSERT INTO SizeOfPackages(Id, Weight, Pricing) VALUES(3, 5, 6)");
            Sql("INSERT INTO SizeOfPackages(Id, Weight, Pricing) VALUES(4, 10, 9)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(1, 3)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(2, 2)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(3, 3)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(4, 4)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(5, 4)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(6, 6)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(7, 6)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(8, 6)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(9, 6)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(10, 6)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(11, 6)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(12, 7)");
            Sql("INSERT INTO ChargeOfPackages(Id, ChargeByRegion) VALUES(13, 8)");
        }
        
        public override void Down()
        {
        }
    }
}
