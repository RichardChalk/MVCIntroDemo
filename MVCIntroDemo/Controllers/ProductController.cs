using Microsoft.AspNetCore.Mvc;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
            public int Qty { get; set; }
        }
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
        public IActionResult Index()
        {
            Products.Add(new ProductViewModel{ 
                Id = 1, 
                Name = "XBox", 
                Price = 1500, 
                Qty = 10 
            });
            Products.Add(new ProductViewModel
            {
                Id = 2,
                Name = "PS5",
                Price = 5000,
                Qty = 100
            });

            return View(Products);
        }
    }
}
