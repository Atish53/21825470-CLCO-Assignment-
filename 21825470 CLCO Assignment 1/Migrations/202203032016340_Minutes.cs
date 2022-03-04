namespace _21825470_CLCO_Assignment_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Minutes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Minutes", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Minutes");
        }
    }
}
