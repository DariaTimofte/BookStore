using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;
using BookStoreApp.IRepositories;
using BookStoreApp.Data;

namespace BookStoreApp.Repositories
{
    public class FidelityBonusRepository : GenericRepository<FidelityBonus>, IFidelityBonusRepository
    {
        public FidelityBonusRepository(BookStoreDbContext context) : base(context)
        {
        }
    }
}
