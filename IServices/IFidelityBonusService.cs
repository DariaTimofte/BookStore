using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;

namespace BookStoreApp.IServices
{
    public interface IFidelityBonusService
    {
        List<FidelityBonus> GetAll();
        FidelityBonus GetById(int id);
        bool Add(FidelityBonus client);
        bool Update(FidelityBonus client);
        bool Delete(int id);
    }
}
