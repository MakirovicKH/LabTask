using Microsoft.AspNetCore.Mvc;
using ProniaDL.Contexts;
using ProniaDL.Models;

namespace Pronia.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaDBContext _context;
        public HomeController()
        {
            _context = new ProniaDBContext();   
        }
        public IActionResult Index()
        {
            List<SliderItem> sliderItems = _context.SliderItems.ToList();
            return View();
        }
    }
}
