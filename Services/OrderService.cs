using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;
using BookStoreApp.IRepositories;
using BookStoreApp.IServices;
using Microsoft.Extensions.Options;

namespace BookStoreApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly Models.AppSettings _appSettings;
        public OrderService(IOrderRepository orderRepository, IOptions<Models.AppSettings> options)
        {
            this._repository = orderRepository;
            this._appSettings = options.Value;
        }

        public bool Delete(int id)
        {
            var order = this.GetById(id);
            _repository.Delete(order);
            return _repository.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _repository.GetAll();
        }

        public Order GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Order order)
        {
            _repository.Add(order);
            return _repository.SaveChanges();
        }

        public bool Update(Order order)
        {
            _repository.Update(order);
            return _repository.SaveChanges();
        }
    }
}
