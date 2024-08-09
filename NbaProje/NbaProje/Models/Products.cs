using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaProje.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public Products()
        {
            Category = new Category();
        }
    }
}
