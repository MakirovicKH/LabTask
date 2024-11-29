using Microsoft.AspNetCore.Mvc;

namespace Uniqlo.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
