namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentalClassDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        RentalId = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Customer_Customerid = c.Int(nullable: false),
                        Movie_Movieid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RentalId)
                .ForeignKey("dbo.Customers", t => t.Customer_Customerid, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Movieid, cascadeDelete: true)
                .Index(t => t.Customer_Customerid)
                .Index(t => t.Movie_Movieid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Movieid", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Customerid", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "Movie_Movieid" });
            DropIndex("dbo.Rentals", new[] { "Customer_Customerid" });
            DropTable("dbo.Rentals");
        }
    }
}
