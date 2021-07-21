using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommandsTest.Data;
using CommandsTest.Helpers;
using CommandsTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CommandsTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommandsController : Controller
    {
        private readonly IRepository _repository;

        public CommandsController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: commands
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commands>>> GetAllCommands()
        {
            return Ok(await _repository.GetAllCommands());
        }

        // GET: commands/{id}
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Commands>> GetCommand(Guid id)
        {
            var command = await _repository.GetCommandById(id);

            if (command == null)
            {
                return NotFound();
            }

            return command;
        }

        // POST: commands
        // Example Post:
        //  {
        //    "description": "Description 7",
        //    "key": "Key 7"
        //  }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddCommand([Bind("Id,Description,Key")] Commands command)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddCommand(command);
                return Ok();
            }
            return NotFound();
        }

        // DELETE: commands/{Id}
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Commands>> DeleteCommandById(Guid id)
        {
            var result = await _repository.DeleteCommandById(id);
            if (!result)  {
                return NotFound();
            } 
            
            return Ok();
        }

    }
}