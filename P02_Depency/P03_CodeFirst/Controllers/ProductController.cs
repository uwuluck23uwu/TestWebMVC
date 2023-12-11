using Microsoft.AspNetCore.Mvc;
using P03_CodeFirst.Services;

namespace P03_CodeFirst.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ps;

        public ProductController (IProductService ps) 
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            var products = ps.GetAll();
            return View(products);
        }
        public IActionResult Delete(int id)
        {
            var product = ps.GetById(id);
            if (product == null)
            {
                TempData["OK"] = true;
            }
            else
            {
                ps.Delete(product);
            }
            return RedirectToAction("Index");
        }
    }
}
