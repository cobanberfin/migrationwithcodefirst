namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EkleSuplierproductiliski : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SuplierID", c => c.Int());
            CreateIndex("dbo.Products", "SuplierID");
            AddForeignKey("dbo.Products", "SuplierID", "dbo.Supliers", "SuplierID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SuplierID", "dbo.Supliers");
            DropIndex("dbo.Products", new[] { "SuplierID" });
            DropColumn("dbo.Products", "SuplierID");
        }
    }
}
