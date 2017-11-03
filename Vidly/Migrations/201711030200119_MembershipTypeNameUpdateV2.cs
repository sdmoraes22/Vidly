namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeNameUpdateV2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Common' where Id =1");
            Sql("UPDATE MembershipTypes set Name = 'Monthly' where Id =2");
            Sql("UPDATE MembershipTypes set Name = 'Trimestral' where Id =3");
            Sql("UPDATE MembershipTypes set Name = 'Anual' where Id =4");
        }
        
        public override void Down()
        {
        }
    }
}
