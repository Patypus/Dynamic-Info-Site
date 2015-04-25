using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSiteServer.Exceptions
{
    public class MalformedConfigFileException : Exception
    {
        /// <summary>
        /// Exception indicating that a config file for the site could not be loaded.
        /// </summary>
        /// <param name="message">String message to explain which config file cannot be loaded</param>
        public MalformedConfigFileException(string message) : base(message)
        {
        }
    }
}
