using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;
using BookStoreApp.Models;

namespace BookStoreApp.IServices
{
    public interface IClientService
    {
        List<Client> GetAll();
        Client GetById(int id);
        bool Add(Client client);
        bool Update(Client client);
        bool Delete(int id);
        AuthenticationResponse Register(AuthenticationRequest request);
        AuthenticationResponse Login(AuthenticationRequest request);
    }


}
