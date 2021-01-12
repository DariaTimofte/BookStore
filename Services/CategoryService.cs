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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly Models.AppSettings _appSettings;
        public CategoryService(ICategoryRepository categoryRepository, IOptions<Models.AppSettings> options)
        {
            this._repository = categoryRepository;
            this._appSettings = options.Value;
        }

        public bool Delete(int id)
        {
            var category = this.GetById(id);
            _repository.Delete(category);
            return _repository.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Category category)
        {
            _repository.Add(category);
            return _repository.SaveChanges();
        }

        public bool Update(Category category)
        {
            _repository.Update(category);
            return _repository.SaveChanges();
        }
    }
}
