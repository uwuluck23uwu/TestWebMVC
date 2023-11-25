using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            var product = new List<Product>()
            {
                new Product() {Id = 1, Name = "<3 Gojo <3", Price = 10000, Amount = 20},
                new Product() {Id = 2, Name = "<3 Geto <3", Price = 20000, Amount = 20},
                new Product() {Id = 3, Name = "<3 Nanami <3", Price = 30000, Amount = 20},
                new Product() {Id = 4, Name = "<3 Joso <3", Price = 40000, Amount = 20}
            };
            return View(new {product, Title = "< คนหล่อเท่ >"});
        }
    }
}
