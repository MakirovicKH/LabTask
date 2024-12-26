using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices<Product> _productService;

        public ProductController(IProductServices<Product> workshopService)
        {
            _workshopService = workshopService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var workshops = await _workshopService.GetAllAsync();
            return Ok(workshops);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var workshop = await _workshopService.GetByIdAsync(id);
            if (workshop == null) return NotFound();
            return Ok(workshop);
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkshopDTO workshopDto)
        {
            Product Product = new()
            {
                Title = workshopDto.Title,
                Description = workshopDto.Description,
                Location = workshopDto.Location,
                CreatedAt = DateTime.Now,
                Date = workshopDto.StartDate,
                CreatedBy = workshopDto.CreatedBy,
                UpdatedBy = workshopDto.UpdatedBy,
                UpdatedAt = DateTime.Now,

            };

            await _workshopService.AddAsync(Product);
            return Ok(Product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, WorkshopDTO workshopDto)
        {

            Product Product = new()
            {
                Id = id,
                Title = workshopDto.Title,
                Description = workshopDto.Description,
                Location = workshopDto.Location,
                CreatedAt = DateTime.Now,
                Date = workshopDto.StartDate,
                CreatedBy = workshopDto.CreatedBy,
                UpdatedBy = workshopDto.UpdatedBy,
                UpdatedAt = DateTime.Now,

            };


            await _workshopService.UpdateAsync(Product);
            return Ok(Product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            await _workshopService.SoftDeleteAsync(id);
            return Ok();
        }
    }
