using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWithoutAutoMigration.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int QuantityPerUnit { get; set; }
        public Category Category { get; set; }  //bır urunun bır tane categryolur
        public Suplier Suplier { get; set; } //bir ürünün bir tane sağlayıcı var
    }
}