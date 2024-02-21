using Microsoft.AspNetCore.Mvc;

namespace PFA_Project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
