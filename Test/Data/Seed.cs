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
            var category1 = new ProductCategory() { Name = "TV" };
            var category2 = new ProductCategory() { Name = "DVD" };
            var category3 = new ProductCategory() { Name = "VHS" };
            var product1 = new Product() { Name = "Samsung SmartTv", Price = 1000, Category = category1 };
            var product2 = new Product() { Name = "Sony SmartTv", Price = 1000, Category = category1 };

            context.Products.AddRange(product1, product2);
            context.Categories.AddRange(category1, category2, category3);
            context.SaveChanges();
        }
    }
}
