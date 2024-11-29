using Microsoft.AspNetCore.Mvc;

namespace Uniqlo.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
