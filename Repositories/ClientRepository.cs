using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;
using BookStoreApp.IRepositories;
using BookStoreApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(BookStoreDbContext context) : base(context)
        {
        }

        public Client GetByEmailAndPassword(string email, string password)
        {
            return _table.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }
    }
}
