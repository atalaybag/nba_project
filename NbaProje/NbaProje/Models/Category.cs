using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaProje.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Definition { get; set; }
        public List<Products> Products { get; set; }
        public Category()
        {
            Products = new List<Products>();
        }
    }
}
