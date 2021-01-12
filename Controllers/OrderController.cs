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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
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
        public IActionResult GetOrder(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        [Authorize]
        public IActionResult UpdateOrder(Order order)
        {
            _service.Update(order);
            return Ok("Order has been successfully updated!");
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult AddOrder(Order order)
        {
            _service.Add(order);
            return Ok("Order has been successfully added!");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteOrder(int id)
        {
            _service.Delete(id);
            return Ok("Order has been successfully deleted!");
        }
    }
}
