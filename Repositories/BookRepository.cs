using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;
using BookStoreApp.IRepositories;
using BookStoreApp.Data;

namespace BookStoreApp.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(BookStoreDbContext context) : base(context)
    {
    }
}
}
