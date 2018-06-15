namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeAvaiableMoviesColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvaiable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
