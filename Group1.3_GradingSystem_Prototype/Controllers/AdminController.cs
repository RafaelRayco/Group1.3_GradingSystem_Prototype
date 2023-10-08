using Microsoft.AspNetCore.Mvc;

namespace Group1._3_GradingSystem_Prototype.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AdminLoginPage()
        {
            return View();
        }
    }
}
