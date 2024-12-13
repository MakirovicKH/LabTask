using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Controllers
{
    public class OurShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
