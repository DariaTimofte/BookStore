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
    public class FidelityBonusService : IFidelityBonusService
    {
        private readonly IFidelityBonusRepository _repository;
    private readonly Models.AppSettings _appSettings;
    public FidelityBonusService(IFidelityBonusRepository fidelityBonusRepository, IOptions<Models.AppSettings> options)
    {
        this._repository = fidelityBonusRepository;
        this._appSettings = options.Value;
    }

    public bool Delete(int id)
    {
        var bonus = this.GetById(id);
        _repository.Delete(bonus);
        return _repository.SaveChanges();
    }

    public List<FidelityBonus> GetAll()
    {
        return _repository.GetAll();
    }

    public FidelityBonus GetById(int id)
    {
        return _repository.FindById(id);
    }

    public bool Add(FidelityBonus bonus)
    {
        _repository.Add(bonus);
        return _repository.SaveChanges();
    }

    public bool Update(FidelityBonus bonus)
    {
        _repository.Update(bonus);
        return _repository.SaveChanges();
    }
}
}
