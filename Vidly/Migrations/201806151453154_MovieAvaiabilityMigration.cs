namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieAvaiabilityMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvaiable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvaiable");
        }
    }
}
