using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStoreApp.IServices;
using BookStoreApp.Entities;
using BookStoreApp.Helpers;

namespace BookStoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;
        public AuthorController(IAuthorService service)
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
        public IActionResult GetAuthor(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        [Authorize]
        public IActionResult UpdateAuthor(Author author)
        {
            _service.Update(author);
            return Ok("Author has been successfully updated!");
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult AddAuthor(Author author)
        {
            _service.Add(author);
            return Ok("Author has been successfully added!");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteAuthor(int id)
        {
            _service.Delete(id);
            return Ok("Author has been successfully deleted!");
        }
    }
}
