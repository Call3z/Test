using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Models;

namespace Test.Data
{
    public static class Seed
    {
        public static void Initialize(ApplicationDbContext context)
        {
            var category1 = new ProductCategory() { Name = "Telefon" };
            var category2 = new ProductCategory() { Name = "Tv" };
            var product1 = new Product() { Name = "Samsung galaxy", Price = 1000, Category = category1 };
            var product2 = new Product() { Name = "Sony SmartTv", Price = 1000, Category = category2 };

            context.Products.AddRange(product1, product2);
            context.SaveChanges();
        }
    }
}
