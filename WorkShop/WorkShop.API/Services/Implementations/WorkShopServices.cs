
using WorkShop.DAL.Interfaces;
using WorkShop.API.Services.Interfaces;
using WorkShopModel.Models.Base;
using WorkShopModel.Models;

namespace WorkShop.API.Services.Implementations;

public class WorkShopServices : IWorkShopServices<WorkShopItem>
{
    private readonly IRepository<WorkShopItem> _repository;

    public WorkShopServices(IRepository<WorkShopItem> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(WorkShopItem entity)
    {
        await _repository.AddAsync(entity);
    }

    public async Task<IEnumerable<WorkShopItem>> GetAllAsync()
    {
        return await _repository.GetAllAsync();

    }

    public async Task<WorkShopItem> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task HardDeleteAsync(int id)
    {
        await _repository.HardDeleteAsync(id);
    }

    public async Task SoftDeleteAsync(int id)
    {
        await _repository.SoftDeleteAsync(id);
    }

    public async Task UpdateAsync(WorkShopItem entity)
    {
        await _repository.UpdateAsync(entity);
    }

    internal async Task DeleteWorkshopAsync(int id)
    {
        throw new NotImplementedException();
    }

    internal async Task GetAllWorkshopsAsync()
    {
        throw new NotImplementedException();
    }
}

