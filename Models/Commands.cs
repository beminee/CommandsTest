using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsTest.Models
{
    /// <summary>
    /// Model for Commands
    /// </summary>
    public class Commands
    {
        /// <summary>
        /// Id field of the command.
        /// This is a unique key in the in the database.
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Description field for the command.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Key to the command.
        /// </summary>
        public string Key { get; set; }
    }
}
