namespace CodeFirstWithoutAutoMigration.Migrations
{
    using CodeFirstWithoutAutoMigration.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstWithoutAutoMigration.Entity.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstWithoutAutoMigration.Entity.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            ////kategori ekle
            //context.Kategoriler.AddOrUpdate(new Category()
            //{
            //    CategoryName = "Donanım",
            //    Description = "Donanım Ürünleri"
            //},
            //new Category() { CategoryName = "Yazılım", Description = "Yazılım Ürünleri" },
            //new Category()
            //{
            //    CategoryName = "Kırtasıye",
            //    Description = "Kırtasıye urunlerı"
            //}

            //);

        }
    }
}
