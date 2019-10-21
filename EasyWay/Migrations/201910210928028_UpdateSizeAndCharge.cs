namespace EasyWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSizeAndCharge : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE SizeOfPackages SET Name = 'Μικρό μέγεθος' WHERE Id = 1");
            Sql("UPDATE SizeOfPackages SET Name = 'Μεσαίο μέγεθος' WHERE Id = 2");
            Sql("UPDATE SizeOfPackages SET Name = 'Μεγάλο μέγεθος' WHERE Id = 3");
            Sql("UPDATE SizeOfPackages SET Name = 'Πολύ μεγάλο μέγεθος' WHERE Id = 4");
            Sql("UPDATE ChargeOfPackages SET Name = 'Ανατολική Μακεδονία και Θράκη' WHERE Id = 1");
            Sql("UPDATE ChargeOfPackages SET Name = 'Κεντρική Μακεδονία' WHERE Id = 2");
            Sql("UPDATE ChargeOfPackages SET Name = 'Δυτική Μακεδονία' WHERE Id = 3");
            Sql("UPDATE ChargeOfPackages SET Name = 'Ήπειρος' WHERE Id = 4");
            Sql("UPDATE ChargeOfPackages SET Name = 'Θεσσαλία' WHERE Id = 5");
            Sql("UPDATE ChargeOfPackages SET Name = 'Ιόνιοι Νήσοι' WHERE Id = 6");
            Sql("UPDATE ChargeOfPackages SET Name = 'Δυτική Ελλάδα' WHERE Id = 7");
            Sql("UPDATE ChargeOfPackages SET Name = 'Στερεά Ελλάδα' WHERE Id = 8");
            Sql("UPDATE ChargeOfPackages SET Name = 'Αττική' WHERE Id = 9");
            Sql("UPDATE ChargeOfPackages SET Name = 'Πελοπόννησος' WHERE Id = 10");
            Sql("UPDATE ChargeOfPackages SET Name = 'Βόρειο Αιγαίο' WHERE Id = 11");
            Sql("UPDATE ChargeOfPackages SET Name = 'Νότιο Αιγαίο' WHERE Id = 12");
            Sql("UPDATE ChargeOfPackages SET Name = 'Κρήτη' WHERE Id = 13");
        }
        
        public override void Down()
        {
        }
    }
}
