using migrationauto.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace migrationauto.Entity
{
    public class DatabaseContext : DbContext

    {
        public DatabaseContext() : base("DatabaseContext")
        {

        }
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Suplier> Suplier{ get; set; }
    }
         
    
}
