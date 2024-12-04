using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Uniqlo.BL.Services.Abstractions;
using Uniqlo.BL.Services.Concretes;
using Uniqlo.DAL.Models;

namespace Uniqlo.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderItemService _sliderItemService;
        public HomeController(ISliderItemService sliderItemService)
        {
            _sliderItemService = sliderItemService;
        }

        public async Task<IActionResult> Index()
        {
            List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
            return View(sliderItems);

        }
    }
}
