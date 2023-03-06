using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType("DECIMAL(19.4)")]
        public decimal? Price { get; set; }
        public int Stock { get; set; }
    }
}
