
namespace FlamesShield
{
    partial class Form1
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
            this.consoleStripOne = new System.Windows.Forms.StatusStrip();
            this.APIScanner = new System.Diagnostics.Process();
            this.FileScanner1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveReportScannerOne = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbClient = new System.Windows.Forms.TabPage();
            this.TbFC = new System.Windows.Forms.TabPage();
            this.tBTools = new System.Windows.Forms.TabPage();
            this.tbHelp = new System.Windows.Forms.TabPage();
            this.tbAbout = new System.Windows.Forms.TabPage();
            this.btnScan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtboxLogs = new System.Windows.Forms.RichTextBox();
            this.btnFirewall = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnOptimizer = new System.Windows.Forms.Button();
            this.btnDNSManager = new System.Windows.Forms.Button();
            this.txtboxHelp = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtboxAbout = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tbClient.SuspendLayout();
            this.tBTools.SuspendLayout();
            this.tbHelp.SuspendLayout();
            this.tbAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleStripOne
            // 
            this.consoleStripOne.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consoleStripOne.Location = new System.Drawing.Point(0, 428);
            this.consoleStripOne.Name = "consoleStripOne";
            this.consoleStripOne.Size = new System.Drawing.Size(800, 22);
            this.consoleStripOne.TabIndex = 0;
            this.consoleStripOne.Text = "Console";
            // 
            // APIScanner
            // 
            this.APIScanner.StartInfo.Domain = "";
            this.APIScanner.StartInfo.LoadUserProfile = false;
            this.APIScanner.StartInfo.Password = null;
            this.APIScanner.StartInfo.StandardErrorEncoding = null;
            this.APIScanner.StartInfo.StandardOutputEncoding = null;
            this.APIScanner.StartInfo.UserName = "";
            this.APIScanner.SynchronizingObject = this;
            // 
            // FileScanner1
            // 
            this.FileScanner1.FileName = "FileScanner1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbClient);
            this.tabControl1.Controls.Add(this.TbFC);
            this.tabControl1.Controls.Add(this.tBTools);
            this.tabControl1.Controls.Add(this.tbHelp);
            this.tabControl1.Controls.Add(this.tbAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tbClient
            // 
            this.tbClient.Controls.Add(this.txtboxLogs);
            this.tbClient.Controls.Add(this.progressBar1);
            this.tbClient.Controls.Add(this.btnExit);
            this.tbClient.Controls.Add(this.button1);
            this.tbClient.Controls.Add(this.btnScan);
            this.tbClient.Location = new System.Drawing.Point(4, 25);
            this.tbClient.Name = "tbClient";
            this.tbClient.Padding = new System.Windows.Forms.Padding(3);
            this.tbClient.Size = new System.Drawing.Size(780, 397);
            this.tbClient.TabIndex = 0;
            this.tbClient.Text = "Client";
            this.tbClient.UseVisualStyleBackColor = true;
            // 
            // TbFC
            // 
            this.TbFC.Location = new System.Drawing.Point(4, 25);
            this.TbFC.Name = "TbFC";
            this.TbFC.Padding = new System.Windows.Forms.Padding(3);
            this.TbFC.Size = new System.Drawing.Size(780, 397);
            this.TbFC.TabIndex = 1;
            this.TbFC.Text = "File Checker";
            this.TbFC.UseVisualStyleBackColor = true;
            // 
            // tBTools
            // 
            this.tBTools.Controls.Add(this.btnDNSManager);
            this.tBTools.Controls.Add(this.btnOptimizer);
            this.tBTools.Controls.Add(this.btnLogs);
            this.tBTools.Controls.Add(this.btnFirewall);
            this.tBTools.Location = new System.Drawing.Point(4, 25);
            this.tBTools.Name = "tBTools";
            this.tBTools.Size = new System.Drawing.Size(780, 397);
            this.tBTools.TabIndex = 2;
            this.tBTools.Text = "Tools";
            this.tBTools.UseVisualStyleBackColor = true;
            // 
            // tbHelp
            // 
            this.tbHelp.Controls.Add(this.statusStrip1);
            this.tbHelp.Controls.Add(this.txtboxHelp);
            this.tbHelp.Location = new System.Drawing.Point(4, 25);
            this.tbHelp.Name = "tbHelp";
            this.tbHelp.Size = new System.Drawing.Size(780, 397);
            this.tbHelp.TabIndex = 3;
            this.tbHelp.Text = "Help";
            this.tbHelp.UseVisualStyleBackColor = true;
            // 
            // tbAbout
            // 
            this.tbAbout.Controls.Add(this.txtboxAbout);
            this.tbAbout.Location = new System.Drawing.Point(4, 25);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(780, 397);
            this.tbAbout.TabIndex = 4;
            this.tbAbout.Text = "About";
            this.tbAbout.UseVisualStyleBackColor = true;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(6, 19);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(86, 78);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 91);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 365);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(766, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // txtboxLogs
            // 
            this.txtboxLogs.Location = new System.Drawing.Point(98, 19);
            this.txtboxLogs.Name = "txtboxLogs";
            this.txtboxLogs.ReadOnly = true;
            this.txtboxLogs.Size = new System.Drawing.Size(661, 353);
            this.txtboxLogs.TabIndex = 4;
            this.txtboxLogs.Text = "";
            // 
            // btnFirewall
            // 
            this.btnFirewall.Location = new System.Drawing.Point(48, 121);
            this.btnFirewall.Name = "btnFirewall";
            this.btnFirewall.Size = new System.Drawing.Size(203, 75);
            this.btnFirewall.TabIndex = 0;
            this.btnFirewall.Text = "Firewall";
            this.btnFirewall.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(48, 245);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(203, 75);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnOptimizer
            // 
            this.btnOptimizer.Location = new System.Drawing.Point(470, 121);
            this.btnOptimizer.Name = "btnOptimizer";
            this.btnOptimizer.Size = new System.Drawing.Size(203, 75);
            this.btnOptimizer.TabIndex = 2;
            this.btnOptimizer.Text = "Optimize PC";
            this.btnOptimizer.UseVisualStyleBackColor = true;
            // 
            // btnDNSManager
            // 
            this.btnDNSManager.Location = new System.Drawing.Point(470, 245);
            this.btnDNSManager.Name = "btnDNSManager";
            this.btnDNSManager.Size = new System.Drawing.Size(203, 75);
            this.btnDNSManager.TabIndex = 3;
            this.btnDNSManager.Text = "DNS Manager";
            this.btnDNSManager.UseVisualStyleBackColor = true;
            // 
            // txtboxHelp
            // 
            this.txtboxHelp.Location = new System.Drawing.Point(8, 29);
            this.txtboxHelp.Name = "txtboxHelp";
            this.txtboxHelp.ReadOnly = true;
            this.txtboxHelp.Size = new System.Drawing.Size(769, 343);
            this.txtboxHelp.TabIndex = 0;
            this.txtboxHelp.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtboxAbout
            // 
            this.txtboxAbout.Location = new System.Drawing.Point(3, 21);
            this.txtboxAbout.Name = "txtboxAbout";
            this.txtboxAbout.ReadOnly = true;
            this.txtboxAbout.Size = new System.Drawing.Size(769, 356);
            this.txtboxAbout.TabIndex = 0;
            this.txtboxAbout.Text = "(C) Flames Co. Fixtures - 2021 - Team Flames";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.consoleStripOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FlamesShield 2021 ";
            this.tabControl1.ResumeLayout(false);
            this.tbClient.ResumeLayout(false);
            this.tBTools.ResumeLayout(false);
            this.tbHelp.ResumeLayout(false);
            this.tbHelp.PerformLayout();
            this.tbAbout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip consoleStripOne;
        private System.Diagnostics.Process APIScanner;
        private System.Windows.Forms.OpenFileDialog FileScanner1;
        private System.Windows.Forms.SaveFileDialog SaveReportScannerOne;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbClient;
        private System.Windows.Forms.TabPage TbFC;
        private System.Windows.Forms.TabPage tBTools;
        private System.Windows.Forms.TabPage tbHelp;
        private System.Windows.Forms.TabPage tbAbout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox txtboxLogs;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnFirewall;
        private System.Windows.Forms.Button btnOptimizer;
        private System.Windows.Forms.Button btnDNSManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox txtboxHelp;
        private System.Windows.Forms.RichTextBox txtboxAbout;
    }
}

