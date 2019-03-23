using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroMart.Entities
{
   public class SubCategory:BaseEntity
    {
        public MainCategory MainCategory { get; set; }
        public Category Category { get; set; }
    }
}
