using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLogger.Loggers
{
    interface ILogger
    {
        public void Log(string value);
        public void Save();
    }
}
