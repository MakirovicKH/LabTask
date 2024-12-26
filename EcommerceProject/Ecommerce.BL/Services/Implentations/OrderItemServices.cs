using Ecommerce.BL.Services.Interfaces;
using Ecommerce.DAL.Interfaces;
using Ecommerce.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.BL.Services.Implentations
{

    public class OrderItemServices : IOrderItemServices
    {
        private readonly IRepository<OrderItem> _repository;
        public OrderItemServices(IRepository<OrderItem> repository)
        { 
            _repository = repository;
        }

        public async Task AddAsync(OrderItem entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderItem>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<OrderItem> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public Task HardDeleteAsync(int id)
        {
            return _repository.HardDeleteAsync(id);
        }

        public Task SoftDeleteAsync(int id)
        {
            return _repository.SoftDeleteAsync(id);
        }

        public Task UpdateAsync(OrderItem entity)
        {
            return _repository.UpdateAsync(entity);
        }
    }
}
