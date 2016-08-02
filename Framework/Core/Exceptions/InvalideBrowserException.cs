using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Exceptions
{
    public class InvalideBrowserException : Exception
    {

        public InvalideBrowserException() { }

        public InvalideBrowserException(string message) : base(message) { }

        public override string Message
        {
            get
            {
                return string.Format("You have invalid browser name in configuration file. Valid browsers: FireFox, Chrome, Opera, IE");
            }
        }
    }
}
