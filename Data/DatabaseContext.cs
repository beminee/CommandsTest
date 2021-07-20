using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsTest.Models;
using Microsoft.EntityFrameworkCore;


namespace CommandsTest.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Commands> Commands { get; set; }

        /// <summary>
        /// Adding dummy commands for testing purposes.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            var dummyCommands = new Commands[]
            {
                new Commands
                {
                    Id = Guid.NewGuid(),
                    Key = "Key 1",
                    Description = "Description 1"
                },

                new Commands
                {
                    Id = Guid.NewGuid(),
                    Key = "Key 2",
                    Description = "Description 2"
                },

                new Commands
                {
                    Id = Guid.NewGuid(),
                    Key = "Key 3",
                    Description = "Description 3"
                },

                new Commands
                {
                    Id = Guid.NewGuid(),
                    Key = "Key 4",
                    Description = "Description 4"
                },

                new Commands
                {
                    Id = Guid.NewGuid(),
                    Key = "Key 5",
                    Description = "Description 5"
                },
            };

            modelBuilder.Entity<Commands>().HasData(dummyCommands);
            */
            base.OnModelCreating(modelBuilder);
        }
    }
}
