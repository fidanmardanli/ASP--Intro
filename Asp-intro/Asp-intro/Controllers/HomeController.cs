using Microsoft.AspNetCore.Mvc;

namespace Asp_intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return "Home Page" + "-" + id + "-" + name;
            return View();
            //return Json(new { name = "Fidan", surname = "Mardanli" });
            //return Content("Salamlarrr zuu");
        }

        //public int Age(int id)
        //{
        //    return id;
        //}

        public string Fulldata(string name, string surname, int age)
        {
            return $"Name-{name}: Surname-{surname}: Age-{age}";
        }
    }
}
