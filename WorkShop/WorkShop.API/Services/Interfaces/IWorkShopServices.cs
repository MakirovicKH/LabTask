using WorkShopModel.Models.Base;

namespace WorkShop.API.Services.Interfaces
{
    public interface IWorkShopServices<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task SoftDeleteAsync(int id);
        Task HardDeleteAsync(int id);
    }
}
