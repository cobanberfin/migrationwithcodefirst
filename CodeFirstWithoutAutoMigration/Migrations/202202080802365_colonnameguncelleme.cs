namespace CodeFirstWithoutAutoMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class colonnameguncelleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            //silmeden önceiçerisindekı verileri kurtarabılırım:
            Sql("Update dbo.Categories set Name=CategoryName");//nameın ıcıne cat.nameı al
            DropColumn("dbo.Categories", "CategoryName");
        }
        
        public override void Down()  
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());

            Sql("Update dbo.Categories set CategoryName=Name");//tam tersı

            DropColumn("dbo.Categories", "Name");
        }
    }
}
