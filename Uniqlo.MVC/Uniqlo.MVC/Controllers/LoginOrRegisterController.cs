using Microsoft.AspNetCore.Mvc;

namespace Uniqlo.MVC.Controllers
{
    public class LoginOrRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
