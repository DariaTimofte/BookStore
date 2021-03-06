﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Entities;

namespace BookStoreApp.IRepositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetByEmailAndPassword(string email, string password);
    }
}
