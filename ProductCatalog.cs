using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice
{
    public class ProductCatalog
    {
        public Dictionary<string, Product> Products { get; set; } = [];

        public void LoadProducts()
        {
            // read JSON
            // turn JSON into Dictionary<string, Product>
        }
    }
}