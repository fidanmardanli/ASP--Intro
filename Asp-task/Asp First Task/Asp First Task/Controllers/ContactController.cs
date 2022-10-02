using Microsoft.AspNetCore.Mvc;

namespace Asp_First_Task.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
