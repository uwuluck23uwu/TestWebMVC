using Microsoft.AspNetCore.Mvc;
using MVC_Homework_1.Models;
using MVC_Homework_1.Services;

namespace MVC_Homework_1.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IProductService ps;

        public FeatureController(IProductService ps)
        {
            this.ps = ps;
        }

        public async Task<IActionResult> Index()
        {
            return View(await ps.GetFeature());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Feature feature)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.AddFeature(feature);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var feature = await ps.FindFeature(id);
            if (feature != null)
            {
                await ps.DeleteFeature(feature);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id)
        {
            var feature = await ps.FindFeature(id);
            if (feature == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(feature);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Feature feature)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await ps.UpdateFeature(feature);
            return RedirectToAction(nameof(Index));
        }
    }
}
