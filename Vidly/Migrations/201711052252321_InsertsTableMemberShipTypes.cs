namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertsTableMemberShipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes SELECT 1, 'Comum', 0, 0, 0");
            Sql("INSERT INTO MembershipTypes SELECT 2, 'Mensal', 10, 1, 5");
            Sql("INSERT INTO MembershipTypes SELECT 3, 'Trimestral', 30, 3, 10");
            Sql("INSERT INTO MembershipTypes SELECT 4, 'Anual', 80, 12, 15");
        }
        
        public override void Down()
        {
        }
    }
}
