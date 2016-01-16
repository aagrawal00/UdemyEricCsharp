using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UdemyEricCsharp
{
    class FileLogger : ILogger
    {
        public void WriteToLog(string message)
        {
            var fileWriter = File.AppendText("log.txt");
            fileWriter.WriteLine(message);
            fileWriter.Close();
        }
    }
}
