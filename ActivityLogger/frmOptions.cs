using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyLogger
{
    public partial class Frmoptions : Form
    {
        public Frmoptions()
        {
            InitializeComponent();
        }

        private void ChkAutosaverCheckedChanged(object sender, EventArgs e)
        {
            pnl_saver.Enabled = chk_autosaver.Checked;
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            if (chk_autosaver.Checked)
            {
                //check file access and permission
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnBrwoseClick(object sender, EventArgs e)
        {
            var savef = new SaveFileDialog() {Title = "Save ...", Filter = "CSKeylogger log files (*.xml)|*.xml", FileName = "Logfile.xml"};
            if ( savef.ShowDialog() == DialogResult.OK)
            {
                txt_filelocation.Text = savef.FileName;
            }
        }

    }
}
