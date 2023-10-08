using Microsoft.AspNetCore.Mvc;
using Group1._3_GradingSystem_Prototype.Models;


namespace Group1._3_GradingSystem_Prototype.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AdminHomePage()
        {
            return View();
        }

        public ActionResult AdminDashboard()
        {
            return View();
        }

        public ActionResult AdminLoginPage()
        {
            return View();
        }
    }
}
