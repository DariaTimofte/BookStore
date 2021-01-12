using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using BookStoreApp.IServices;
using BookStoreApp.IRepositories;
using BookStoreApp.Entities;
using BookStoreApp.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using BookStoreApp.Mappers;
using System.Security.Claims;
using System.Text;


namespace BookStoreApp.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;
        private readonly Models.AppSettings _appSettings;
        public ClientService(IClientRepository userRepository, IOptions<Models.AppSettings> options)
        {
            this._repository = userRepository;
            this._appSettings = options.Value;
        }

        public bool Delete(int id)
        {
            var client = this.GetById(id);
            _repository.Delete(client);
            return _repository.SaveChanges();
        }

        public List<Client> GetAll()
        {
            return _repository.GetAll();
        }

        public Client GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Add(Client client)
        {
            _repository.Add(client);
            return _repository.SaveChanges();
        }

        public bool Update(Client client)
        {
            _repository.Update(client);
            return _repository.SaveChanges();
        }

        public AuthenticationResponse Register(AuthenticationRequest request)
        {
            var entity = request.ToUserExtension(Enums.UserTypeEnum.Client);

            _repository.Add(entity);
            var token = GenerateJwtForUser(entity);

            _repository.SaveChanges();
            return new AuthenticationResponse
            {
                Id = entity.Id,
                Email = entity.Email,
                Type = entity.Type,
                Token = token
            };
        }

        public AuthenticationResponse Login(AuthenticationRequest request)
        {
            // find user
            var user = _repository.GetByEmailAndPassword(request.Email, request.Password);
            if (user == null)
                return null;

            // attach token
            var token = GenerateJwtForUser(user);

            // return user & token
            return new AuthenticationResponse
            {
                Id = user.Id,
                Email = user.Email,
                Type = user.Type,
                Token = token
            };
        }

        private string GenerateJwtForUser(Client user)
        {
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

}
