using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;

namespace BookStoreApp.IServices
{
    public interface IRoleService
    {
        List<Role> GetAll();
        Role GetById(int id);
        bool Add(Role client);
        bool Update(Role client);
        bool Delete(int id);
    }
}
