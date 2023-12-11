using Microsoft.AspNetCore.Mvc;
using MVC_Homework.IService;

namespace MVC_Homework.Controllers
{
    public class DearFriendController : Controller
    {
        private readonly IServiceDearFriend ps;
        public DearFriendController(IServiceDearFriend ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            return View(ps.GetPets());
        }
    }
}
