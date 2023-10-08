using Microsoft.AspNetCore.Mvc;

namespace Group1._3_GradingSystem_Prototype.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult StudentLoginPage()
        {
            return View();
        }
    }
}
