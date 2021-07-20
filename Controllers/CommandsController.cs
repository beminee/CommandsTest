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
        private readonly DatabaseContext _context;

        public CommandsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: commands
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commands>>> GetAllCommands()
        {
            return await _context.Commands.ToListAsync();
        }

        // GET: commands/{id}
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Commands>> GetCommand(Guid id)
        {
            var command = await _context.Commands.FindAsync(id);

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
            // Not sure if it's the correct approach?
            command.Id = Guid.NewGuid();

            if (ModelState.IsValid)
            {
                _context.Add(command);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }

        // DELETE: commands/{Id}
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Commands>> DeleteCommandById(Guid id)
        {
            var command = await _context.Commands.FindAsync(id);

            if (command == null)
            {
                return NotFound();
            }

            _context.Remove(command);

            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}