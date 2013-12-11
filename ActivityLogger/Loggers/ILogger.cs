using System;
using System.Collections.Generic;
using System.Text;

namespace ActivityLogger.Loggers
{
    interface ILogger
    {
        void Log(string application, string value);
        void Save(string filePath);
    }
}
