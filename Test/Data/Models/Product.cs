using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(5,1000)]
        public decimal Price { get; set; }

        public ProductCategory Category { get; set; }
        public int CategoryId { get; set; }
    }
}
