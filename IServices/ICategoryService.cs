using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;

namespace BookStoreApp.IServices
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        bool Add(Category client);
        bool Update(Category client);
        bool Delete(int id);
    }
}
