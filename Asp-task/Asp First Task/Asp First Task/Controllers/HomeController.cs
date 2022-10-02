using Microsoft.AspNetCore.Mvc;

namespace Asp_First_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
