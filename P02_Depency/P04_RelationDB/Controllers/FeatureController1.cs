using Microsoft.AspNetCore.Mvc;

namespace P04_RelationDB.Controllers
{
    public class FeatureController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
