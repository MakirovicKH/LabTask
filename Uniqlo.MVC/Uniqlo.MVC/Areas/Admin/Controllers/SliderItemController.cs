using Microsoft.AspNetCore.Mvc;
using Uniqlo.BL.Services.Abstractions;
using Uniqlo.DAL.DTOs.SliderItemDTOs;
using Uniqlo.DAL.Models;

namespace Uniqlo.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderItemController : Controller
    {
        private readonly ISliderItemService _sliderItemService;

        public SliderItemController(ISliderItemService sliderItemService)
        {
            _sliderItemService = sliderItemService;
        }

        public async Task<IActionResult> Index()
        {
            List<SliderItem> sliderItems = await _sliderItemService.GetAllSliderItemsAsync();
            return View(sliderItems);
        }

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(SliderItremDTO sliderDto)
        {

            return View();
        }

    }
}
