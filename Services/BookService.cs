using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.IServices;
using BookStoreApp.IRepositories;
using BookStoreApp.Entities;
using Microsoft.Extensions.Options;

namespace BookStoreApp.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly Models.AppSettings _appSettings;
        public BookService(IBookRepository bookRepository, IOptions<Models.AppSettings> options)
        {
            this._repository = bookRepository;
            this._appSettings = options.Value;
        }

        public bool Delete(int id)
        {
            var book = this.GetById(id);
            _repository.Delete(book);
            return _repository.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Book GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Book book)
        {
            _repository.Add(book);
            return _repository.SaveChanges();
        }

        public bool Update(Book book)
        {
            _repository.Update(book);
            return _repository.SaveChanges();
        }
    }
}
