using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithoutAutoMigration.Entity
{
    public class Suplier
    {
        public int SuplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        ICollection<Product> Product { get; set; }
    }
}