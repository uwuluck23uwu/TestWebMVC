using Microsoft.AspNetCore.Mvc;
using MVC_Homework.IService;

namespace MVC_Homework.Controllers
{
    public class CatController : Controller
    {
        private readonly IServiceDearFriend ps;
        public CatController(IServiceDearFriend ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            return View(ps.GetPetsCat());
        }
    }
}
