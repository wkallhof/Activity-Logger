namespace ActivityLogger
{
    partial class Frmoptions
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chk_autosaver = new System.Windows.Forms.CheckBox();
            this.pnl_saver = new System.Windows.Forms.Panel();
            this.btn_brwose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_filelocation = new System.Windows.Forms.TextBox();
            this.numeric_savetimer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_savetimer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(237, 243);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(108, 23);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(10, 243);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 222);
            this.tabControl1.TabIndex = 16;
            // 
            // chk_autosaver
            // 
            this.chk_autosaver.AutoSize = true;
            this.chk_autosaver.Location = new System.Drawing.Point(17, 10);
            this.chk_autosaver.Name = "chk_autosaver";
            this.chk_autosaver.Size = new System.Drawing.Size(188, 17);
            this.chk_autosaver.TabIndex = 9;
            this.chk_autosaver.Text = "Automatically save result to the file";
            this.chk_autosaver.UseVisualStyleBackColor = true;
            this.chk_autosaver.CheckedChanged += new System.EventHandler(this.ChkAutosaverCheckedChanged);
            // 
            // pnl_saver
            // 
            this.pnl_saver.Enabled = false;
            this.pnl_saver.Location = new System.Drawing.Point(7, 33);
            this.pnl_saver.Name = "pnl_saver";
            this.pnl_saver.Size = new System.Drawing.Size(313, 98);
            this.pnl_saver.TabIndex = 15;
            // 
            // btn_brwose
            // 
            this.btn_brwose.Location = new System.Drawing.Point(271, 9);
            this.btn_brwose.Name = "btn_brwose";
            this.btn_brwose.Size = new System.Drawing.Size(31, 23);
            this.btn_brwose.TabIndex = 12;
            this.btn_brwose.Text = "...";
            this.btn_brwose.UseVisualStyleBackColor = true;
            this.btn_brwose.Click += new System.EventHandler(this.BtnBrwoseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            // 
            // txt_filelocation
            // 
            this.txt_filelocation.Location = new System.Drawing.Point(91, 11);
            this.txt_filelocation.Name = "txt_filelocation";
            this.txt_filelocation.ReadOnly = true;
            this.txt_filelocation.Size = new System.Drawing.Size(174, 20);
            this.txt_filelocation.TabIndex = 11;
            // 
            // numeric_savetimer
            // 
            this.numeric_savetimer.Location = new System.Drawing.Point(147, 52);
            this.numeric_savetimer.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numeric_savetimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_savetimer.Name = "numeric_savetimer";
            this.numeric_savetimer.Size = new System.Drawing.Size(47, 20);
            this.numeric_savetimer.TabIndex = 13;
            this.numeric_savetimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnl_saver);
            this.tabPage2.Controls.Add(this.chk_autosaver);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Save to file";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frmoptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 278);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmoptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_savetimer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnl_saver;
        internal System.Windows.Forms.CheckBox chk_autosaver;
        private System.Windows.Forms.Button btn_brwose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txt_filelocation;
        internal System.Windows.Forms.NumericUpDown numeric_savetimer;
        private System.Windows.Forms.Label label7;
    }
}