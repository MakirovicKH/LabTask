
using Uniqlo.BL.Services.Abstractions;
using Uniqlo.DAL.Models;
using Uniqlo.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Uniqlo.DAL.DTOs.SliderItemDTOs;

namespace Uniqlo.BL.Services.Concretes
{
    public class SliderItemService : ISliderItemService
    {
        private readonly UniqloDbContext _context;


        public SliderItemService(UniqloDbContext context)
        {
            _context = context;
        }

        public async Task<List<SliderItem>> GetAllSliderItemsAsync()
        {
            List<SliderItem> sliderItems = await _context.SliderItems.ToListAsync();
            return sliderItems;
        }

        public async Task AddSliderItem(SliderItremDTO sliderItemDto)
        {
            
           var item  =  await _context.SliderItems.AddAsync(sliderItemDto);
            return;


        }

      
    }
}
