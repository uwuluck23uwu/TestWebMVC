using Microsoft.AspNetCore.Mvc;
using MVC_Homework.IService;

namespace MVC_Homework.Controllers
{
    public class ExoticController : Controller
    {
        private readonly IServiceDearFriend ps;
        public ExoticController(IServiceDearFriend ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            return View(ps.GetPets());
        }
    }
}
