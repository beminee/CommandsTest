
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CommandsTest.Models;

namespace CommandsTest.Data
{
    public interface IRepository 
    {
        Task<IEnumerable<Commands>> GetAllCommands();
        Task<Commands> GetCommandById(Guid id);
        Task AddCommand(Commands command);
        Task<bool> DeleteCommandById(Guid id);  
    }
}