using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace P08_Aythorization.Controllers
{
    public class AccountController1cs : Controller
    {
        public UserManager<MyUser> _userManager;

        public AccountController1cs(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
    }
}
