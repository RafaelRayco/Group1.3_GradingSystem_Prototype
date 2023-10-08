using Microsoft.AspNetCore.Mvc;

namespace Group1._3_GradingSystem_Prototype.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult TeacherLoginPage()
        {
            return View();
        }
    }
}
