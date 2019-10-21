namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNamesForSizeAndCharge : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE SizeOfPackages SET Name = 'Small Size < 1kg' WHERE Id = 1");
            Sql("UPDATE SizeOfPackages SET Name = 'Medium Size 1-3 kg' WHERE Id = 2");
            Sql("UPDATE SizeOfPackages SET Name = 'Large Size 3-6 kg' WHERE Id = 3");
            Sql("UPDATE SizeOfPackages SET Name = 'X-Large Size > 6 kg' WHERE Id = 4");
            Sql("UPDATE ChargeOfPackages SET Name = 'Eastern Macedonia and Thrace' WHERE Id = 1");
            Sql("UPDATE ChargeOfPackages SET Name = 'Central Macedonia' WHERE Id = 2");
            Sql("UPDATE ChargeOfPackages SET Name = 'Western Macedonia' WHERE Id = 3");
            Sql("UPDATE ChargeOfPackages SET Name = 'Epirus' WHERE Id = 4");
            Sql("UPDATE ChargeOfPackages SET Name = 'Thessaly' WHERE Id = 5");
            Sql("UPDATE ChargeOfPackages SET Name = 'Ionian Islands' WHERE Id = 6");
            Sql("UPDATE ChargeOfPackages SET Name = 'Western Greece' WHERE Id = 7");
            Sql("UPDATE ChargeOfPackages SET Name = 'Central Greece' WHERE Id = 8");
            Sql("UPDATE ChargeOfPackages SET Name = 'Attica' WHERE Id = 9");
            Sql("UPDATE ChargeOfPackages SET Name = 'Peloponnese' WHERE Id = 10");
            Sql("UPDATE ChargeOfPackages SET Name = 'North Aegean' WHERE Id = 11");
            Sql("UPDATE ChargeOfPackages SET Name = 'South Aegean' WHERE Id = 12");
            Sql("UPDATE ChargeOfPackages SET Name = 'Crete' WHERE Id = 13");
        }
        
        public override void Down()
        {
        }
    }
}
