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
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        public BookController(IBookService service)
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
        public IActionResult GetBook(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        [Authorize]
        public IActionResult UpdateBook(Book book)
        {
            _service.Update(book);
            return Ok("Book has been successfully updated!");
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult AddBook(Book book)
        {
            _service.Add(book);
            return Ok("Book has been successfully added!");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteBook(int id)
        {
            _service.Delete(id);
            return Ok("Book has been successfully deleted!");
        }
    }
}
