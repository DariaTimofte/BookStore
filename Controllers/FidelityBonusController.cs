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
    public class FidelityBonusController : ControllerBase
    {
        private readonly IFidelityBonusService _service;
        public FidelityBonusController(IFidelityBonusService service)
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
        public IActionResult GetBonus(int id)
        {
            var response = _service.GetById(id);
            return Ok(response);
        }

        [HttpPatch("update")]
        [Authorize]
        public IActionResult UpdateBonus(FidelityBonus bonus)
        {
            _service.Update(bonus);
            return Ok("Bonus has been successfully updated!");
        }

        [HttpPost("create")]
        public IActionResult AddBonus(FidelityBonus bonus)
        {
            _service.Add(bonus);
            return Ok("Bonus has been successfully added!");
        }

        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult DeleteBonus(int id)
        {
            _service.Delete(id);
            return Ok("Bonus has been successfully deleted!");
        }
    }
}
