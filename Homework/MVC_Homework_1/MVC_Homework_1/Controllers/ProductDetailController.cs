using Microsoft.AspNetCore.Mvc;
using MVC_Homework_1.Models;
using MVC_Homework_1.Services;

namespace MVC_Homework_1.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IProductService ps;

        public ProductDetailController(IProductService ps)
        {
            this.ps = ps;
        }

        public async Task<IActionResult> Index()
        {
            return View(await ps.GetDetail());
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Product = await ps.GetProduct();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDetail detail)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.AddDetail(detail);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Product = await ps.GetProduct();
            var detail = await ps.FindDetail(id);
            if (detail != null)
            {
                await ps.DeleteDetail(detail);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id)
        {
            ViewBag.Product = await ps.GetProduct();
            var detail = await ps.FindDetail(id);
            if (detail == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(detail);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ProductDetail detail)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.UpdateDetail(detail);
            return RedirectToAction(nameof(Index));
        }
    }
}
