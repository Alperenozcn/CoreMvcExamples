using Example01.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Example01.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            var list = new List<Product>()
            {
                new Product { Id = 1, Name = "Huawei D16" },
                new Product { Id = 2,Name="Apple Mac Pro"},
            };
            return View();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
