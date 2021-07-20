using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsTest.Helpers
{
    public class AppSettings
    {
        /// <summary>
        /// JWT token secret. Currently based on a constant string. Probably has to be generated based on username(?)
        /// </summary>
        public string Secret { get; set; }
    }
}
