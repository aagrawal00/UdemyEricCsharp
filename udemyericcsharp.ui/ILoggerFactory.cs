using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UdemyEricCsharp
{
    static class ILoggerFactory
    {
        private static ILogger _mylogger;

        public static ILogger GetLogger()
        {
            if(_mylogger==null)
            {
                string logType = ConfigurationManager.AppSettings["logtype"];

                if(logType == "C")
                {
                    _mylogger = new ConsoleLogger();
                }
                else if (logType == "F")
                {
                    _mylogger = new FileLogger();
                }
            }
            return _mylogger;
        }
    }
}
