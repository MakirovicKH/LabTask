using WorkShopModel.Models;
using WorkShopModel.Models.Base;

namespace WorkShop.API.Services.Interfaces
{
    public interface IWorkShopServices<WorkShopItem>
    {
         Task<WorkShopItem> GetByIdAsync(int id);
         Task<IEnumerable<WorkShopItem>> GetAllAsync();
         Task AddAsync(WorkShopItem entity);
         Task UpdateAsync(WorkShopItem entity);
         Task SoftDeleteAsync(int id);
         Task HardDeleteAsync(int id);
    }
}
