using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;

namespace BookStoreApp.IServices
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetById(int id);
        bool Add(Book client);
        bool Update(Book client);
        bool Delete(int id);
    }
}
