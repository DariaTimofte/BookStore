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
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _repository;
        private readonly Models.AppSettings _appSettings;
        public AuthorService(IAuthorRepository authorRepository, IOptions<Models.AppSettings> options)
        {
            this._repository = authorRepository;
            this._appSettings = options.Value;
        }

        public bool Delete(int id)
        {
            var author = this.GetById(id);
            _repository.Delete(author);
            return _repository.SaveChanges();
        }

        public List<Author> GetAll()
        {
            return _repository.GetAll();
        }

        public Author GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Author author)
        {
            _repository.Add(author);
            return _repository.SaveChanges();
        }

        public bool Update(Author author)
        {
            _repository.Update(author);
            return _repository.SaveChanges();
        }
    }
}
