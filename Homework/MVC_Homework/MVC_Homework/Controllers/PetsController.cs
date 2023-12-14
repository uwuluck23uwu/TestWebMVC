using Microsoft.AspNetCore.Mvc;
using MVC_Homework.IService;
using MVC_Homework.Models;

namespace MVC_Homework.Controllers
{
    public class PetsController : Controller
    {
        private readonly IServiceDearFriend ps;
        public PetsController(IServiceDearFriend ps)
        {
            this.ps = ps;
        }
        public IActionResult DearFriend()
        {
            return View(ps.GetPets());
        }
        public IActionResult Rookie()
        {
            return View();
        }
        public IActionResult Exotic()
        {
            return View();
        }
        public IActionResult PetsDog()
        {
            return View(ps.GetPetsDog());
        }
        public IActionResult PetsCat()
        {
            return View(ps.GetPetsCat());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pets pets)
        {
            if (!ModelState.IsValid) { return View(); }
            var result = ps.SearchProduct(pets.Id);
            if (result == null)
            {
                ps.AddPets(pets);
            }
            return RedirectToAction("DearFriend");
        }
        public IActionResult Delete(int id)
        {
            ps.DeletePets(id);
            return RedirectToAction("DearFriend");
        }
        public IActionResult Edit(int id)
        {
            var result = ps.SearchProduct(id);
            if (result == null) { return RedirectToAction("DearFriend"); }
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(Pets pets)
        {
            if (!ModelState.IsValid) { return View(); }
            ps.UpdatePets(pets);
            return RedirectToAction("DearFriend");
        }
    }
}
