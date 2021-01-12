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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _service;
        public RoleController(IRoleService service)
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
        public IActionResult GetRole(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        [Authorize]
        public IActionResult UpdateRole(Role role)
        {
            _service.Update(role);
            return Ok("Role has been successfully updated!");
        }

        [HttpPost("create")]
        [Authorize]
        public IActionResult AddRole(Role role)
        {
            _service.Add(role);
            return Ok("Role has been successfully added!");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteRole(int id)
        {
            _service.Delete(id);
            return Ok("Role has been successfully deleted!");
        }
    }
}
