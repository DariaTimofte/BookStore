using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;
using BookStoreApp.Data;
using BookStoreApp.IRepositories;

namespace BookStoreApp.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
