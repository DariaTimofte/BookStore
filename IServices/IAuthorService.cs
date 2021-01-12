using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;

namespace BookStoreApp.IServices
{
    public interface IAuthorService
    {
        List<Author> GetAll();
        Author GetById(int id);
        bool Add(Author author);
        bool Update(Author author);
        bool Delete(int id);
    }
}
