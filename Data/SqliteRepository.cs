using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommandsTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandsTest.Data
{
    public class SqliteRepository : IRepository
    {
        private readonly DatabaseContext _context;

        public SqliteRepository(DatabaseContext context)
        {
            _context = context;   
        }
        public async Task AddCommand(Commands command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.Add(command);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteCommandById(Guid id)
        {
            var command = await _context.Commands.FindAsync(id);
            if (command == null)
            {
                return false;
            }

            _context.Remove(command);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Commands>> GetAllCommands()
        {
            var commands = await _context.Commands.ToListAsync();
            return commands;
        }

        public async Task<Commands> GetCommandById(Guid id)
        {            
            return await _context.Commands.FindAsync(id);
        }
    }
}