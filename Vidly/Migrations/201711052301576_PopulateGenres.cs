namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres SELECT 1, 'Action'");
            Sql("INSERT INTO Genres SELECT 2, 'Comedy'");
            Sql("INSERT INTO Genres SELECT 3, 'Terror'");
            Sql("INSERT INTO Genres SELECT 4, 'Documentary'");
        }
        
        public override void Down()
        {
        }
    }
}
