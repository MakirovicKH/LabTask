
using Microsoft.AspNetCore.Mvc;
using WorkShop.API.Services.Implementations;
using WorkShop.API.Services.Interfaces;
using WorkShopModel.DTOs;
using WorkShopModel.Models;

[ApiController]
[Route("api/[controller]")]
public class WorkshopsController : ControllerBase
{
    private readonly IWorkShopServices<WorkShopItem> _workshopService;

    public WorkshopsController(IWorkShopServices<WorkShopItem> workshopService)
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
        WorkShopItem workShopItem = new()
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

        await _workshopService.AddAsync(workShopItem);
        return Ok(workShopItem);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, WorkshopDTO workshopDto)
    {

        WorkShopItem workShopItem = new()
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

        
        await _workshopService.UpdateAsync(workShopItem);
        return Ok(workShopItem);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {

        await _workshopService.SoftDeleteAsync(id);
        return Ok();
    }
}
