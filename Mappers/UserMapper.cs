using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreApp.Models;
using BookStoreApp.Enums;
using BookStoreApp.Entities;

namespace BookStoreApp.Mappers
{
    public static class ClientMapper
    {
        public static Client ToUser(AuthenticationRequest request, UserTypeEnum userType)
        {
            return new Client
            {
                Email = request.Email,
                Password = request.Password,
                Type = userType.ToString()
            };
        }

        public static Client ToUserExtension(this AuthenticationRequest request, UserTypeEnum userType)
        {
            return new Client
            {
                Email = request.Email,
                Password = request.Password,
                Type = userType.ToString()
            };
        }
    }
}
