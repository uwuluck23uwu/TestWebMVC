using Microsoft.AspNetCore.Mvc;
using MVC_Homework_1.Models;
using MVC_Homework_1.Services;

namespace MVC_Homework_1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService ps;

        public ProductController(IProductService ps)
        {
            this.ps = ps;
        }

        public async Task<IActionResult> Index()
        {
            return View(await ps.GetProduct());
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Category = await ps.GetCategory();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.AddProduct(product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var product = await ps.FindProduct(id);
            if (product != null)
            {
                await ps.DeleteProduct(product);
            }
            return RedirectToAction(nameof(Index));
        } 

        public async Task<ActionResult> Edit(int id)
        {
            ViewBag.Category = await ps.GetCategory();
            var product = await ps.FindProduct(id);
            if (product == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.UpdateProduct(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
