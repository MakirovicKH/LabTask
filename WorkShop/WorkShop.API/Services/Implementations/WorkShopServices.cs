﻿
using WorkShop.DAL.Interfaces;
using WorkShop.API.Services.Interfaces;
using WorkShopModel.Models.Base;

namespace WorkShop.API.Services.Implementations;

public class WorkShopServices<T> : IWorkShopServices<T> where T : BaseEntity
{
        private readonly IRepository<T> _repository;

        public WorkShopServices(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetById(id);
        }



        public async Task HardDeleteAsync(int id)
        {
            await _repository.HardDelete(id);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repository.SoftDelete(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.Update(entity);
        }


    }

