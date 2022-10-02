using Microsoft.AspNetCore.Mvc;

namespace Asp_First_Task.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
