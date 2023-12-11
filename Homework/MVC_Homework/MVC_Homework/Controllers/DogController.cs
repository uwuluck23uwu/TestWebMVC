using Microsoft.AspNetCore.Mvc;
using MVC_Homework.IService;

namespace MVC_Homework.Controllers
{
    public class DogController : Controller
    {
        private readonly IServiceDearFriend ps;
        public DogController(IServiceDearFriend ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            return View(ps.GetPetsDog());
        }
    }
}
