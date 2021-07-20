using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CommandsTest.Models
{
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// User name, self explanatory.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// User password.
        /// </summary>
        [JsonIgnore]
        public string Password { get; set; }
    }
}
