using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace migrationauto.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
      ICollection<Product> Product { get; set; }

    }
}