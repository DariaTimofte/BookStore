using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;

namespace BookStoreApp.IServices
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        bool Add(Order client);
        bool Update(Order client);
        bool Delete(int id);
    }
}
