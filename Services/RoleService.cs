using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using BookStoreApp.IRepositories;
using BookStoreApp.IServices;
using BookStoreApp.Entities;

namespace BookStoreApp.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        private readonly Models.AppSettings _appSettings;
        public RoleService(IRoleRepository roleRepository, IOptions<Models.AppSettings> options)
        {
            this._repository = roleRepository;
            this._appSettings = options.Value;
        }

        public bool Delete(int id)
        {
            var role = this.GetById(id);
            _repository.Delete(role);
            return _repository.SaveChanges();
        }

        public List<Role> GetAll()
        {
            return _repository.GetAll();
        }

        public Role GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Role role)
        {
            _repository.Add(role);
            return _repository.SaveChanges();
        }

        public bool Update(Role role)
        {
            _repository.Update(role);
            return _repository.SaveChanges();
        }
    }
}
