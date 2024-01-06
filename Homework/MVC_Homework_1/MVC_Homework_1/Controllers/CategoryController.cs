using Microsoft.AspNetCore.Mvc;
using MVC_Homework_1.Models;
using MVC_Homework_1.Services;

namespace MVC_Homework_1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductService ps;

        public CategoryController(IProductService ps)
        {
            this.ps = ps;
        }

        public async Task<IActionResult> Index()
        {
            return View(await ps.GetCategory());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.AddCategory(category);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await ps.FindCategory(id);
            if (category != null)
            {
                await ps.DeleteCategory(category);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id)
        {
            var component = await ps.FindCategory(id);
            if (component == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(component);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }
    }
}
