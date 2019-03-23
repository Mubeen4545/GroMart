using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroMart.Entities
{
   public class Product:BaseEntity
    {
        public MainCategory MainCategory { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategoty { get; set; }

        public decimal Price { get; set; }
    }
}
