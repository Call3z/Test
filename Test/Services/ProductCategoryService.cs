using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;

namespace Test.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SelectListItem> GetSelectList()
        {
            var categories = _context.Categories.ToList();
            List<SelectListItem> list = new List<SelectListItem>();
            if (categories != null)
            {
                foreach (var category in categories)
                {
                    list.Add(new SelectListItem() { Selected = false, Text = category.Name, Value = category.Id.ToString() });
                }
            }

            return list;
        }
    }
}
