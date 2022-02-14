namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eklesupliertablosu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supliers",
                c => new
                    {
                        SuplierID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        ContactName = c.String(),
                    })
                .PrimaryKey(t => t.SuplierID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Supliers");
        }
    }
}
