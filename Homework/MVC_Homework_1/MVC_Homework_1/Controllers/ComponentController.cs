using Microsoft.AspNetCore.Mvc;
using MVC_Homework_1.Models;
using MVC_Homework_1.Services;

namespace MVC_Homework_1.Controllers
{
    public class ComponentController : Controller
    {
        private readonly IProductService ps;

        public ComponentController(IProductService ps)
        {
            this.ps = ps;
        }

        public async Task<IActionResult> Index()
        {
            return View(await ps.GetComponent());
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Feature = await ps.GetFeature();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Component component)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.AddComponent(component);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var component = await ps.FindComponent(id);
            if (component != null)
            {
                 await ps.DeleteComponent(component);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id)
        {
            ViewBag.Feature = await ps.GetFeature();
            var component = await ps.FindComponent(id);
            if (component == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(component);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Component component)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.UpdateComponent(component);
            return RedirectToAction(nameof(Index));
        }
    }
}
