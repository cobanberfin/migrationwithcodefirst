namespace migrationauto.Migrations
{
    using migrationauto.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<migrationauto.Entity.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(migrationauto.Entity.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Kategoriler.AddOrUpdate(new Category()
            {
                CategoryName = "Donanım",
                Description="Donanım ürünü"
            }) ;
            
            
        }
    }
}