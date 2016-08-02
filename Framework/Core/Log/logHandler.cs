using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Log
{
    public class logHandler
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void LogToFile(String message)
        {
            logger.Trace(message);
        }


        public static void LogToConsole(String message)
        {
            logger.Debug(message);
        }

    }
}
