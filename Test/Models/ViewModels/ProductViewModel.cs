using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Models;

namespace Test.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public int SelectedCategory { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
