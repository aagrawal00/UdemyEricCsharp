using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UdemyEricCsharp
{
    interface ILogger
    {
        void WriteToLog(string message);
    }
}
