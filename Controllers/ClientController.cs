using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Entities;
using BookStoreApp.IServices;
using BookStoreApp.Helpers;

namespace BookStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _service;
        public ClientController(IClientService service)
        {
            this._service = service;
        }

        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            var response = _service.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetClient(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        [Authorize]
        public IActionResult UpdateClient(Client client)
        {
            _service.Update(client);
            return Ok("Client has been successfully updated!");
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult AddClient(Client client)
        {
            _service.Add(client);
            return Ok("Client has been successfully added!");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteClient(int id)
        {
            _service.Delete(id);
            return Ok("Client has been successfully deleted!");
        }
    }
}
