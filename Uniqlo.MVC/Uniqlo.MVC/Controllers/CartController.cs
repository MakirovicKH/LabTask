using Microsoft.AspNetCore.Mvc;

namespace Uniqlo.MVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
     