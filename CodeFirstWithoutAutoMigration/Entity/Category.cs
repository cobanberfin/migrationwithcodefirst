using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithoutAutoMigration.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }//ıd dersek otomatık 1.cıl anahtar
        public string Name { get; set; }
        public string Description { get; set; }
        ICollection<Product> Product { get; set; }//bir kategorının bıden fazla ürünü olabılır
       
    }
}