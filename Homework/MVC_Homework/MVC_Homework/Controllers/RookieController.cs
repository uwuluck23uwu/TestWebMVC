using Microsoft.AspNetCore.Mvc;
using MVC_Homework.IService;

namespace MVC_Homework.Controllers
{
    public class RookieController : Controller
    {
        private readonly IServiceDearFriend ps;
        public RookieController(IServiceDearFriend ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            return View(ps.GetPets());
        }
    }
}
