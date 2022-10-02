using Microsoft.AspNetCore.Mvc;

namespace Asp_First_Task.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
