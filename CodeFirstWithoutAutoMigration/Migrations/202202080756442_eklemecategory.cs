namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eklemecategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.Categories", "CategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            DropColumn("dbo.Categories", "Name");
        }
    }
}
