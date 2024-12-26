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
    public class OrderServices : IOrderServices
    {
        private readonly IRepository<Order> _repository;
        public OrderServices(IRepository<Order> repository )
        {
            _repository = repository;
        }

        public async Task AddAsync(Order entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Order> GetByIdAsync(int id)
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

        public Task UpdateAsync(Order entity)
        {
            return _repository.UpdateAsync(entity);
        }
    }
}
