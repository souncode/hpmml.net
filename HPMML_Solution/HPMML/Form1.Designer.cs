namespace HPMML
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.pbStt = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbPlc = new System.Windows.Forms.ComboBox();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbFail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbRaw = new System.Windows.Forms.PictureBox();
            this.timerGetTrigger = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStt)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnExit);
            this.panelButton.Controls.Add(this.btnSetting);
            this.panelButton.Controls.Add(this.btnControl);
            this.panelButton.Controls.Add(this.btnMonitor);
            this.panelButton.Controls.Add(this.btnHome);
            resources.ApplyResources(this.panelButton, "panelButton");
            this.panelButton.Name = "panelButton";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Image = global::HPMML.Properties.Resources.leave;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.Image = global::HPMML.Properties.Resources.settings;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnControl
            // 
            resources.ApplyResources(this.btnControl, "btnControl");
            this.btnControl.Image = global::HPMML.Properties.Resources.settings_sliders;
            this.btnControl.Name = "btnControl";
            this.btnControl.UseVisualStyleBackColor = true;
            // 
            // btnMonitor
            // 
            resources.ApplyResources(this.btnMonitor, "btnMonitor");
            this.btnMonitor.Image = global::HPMML.Properties.Resources.browser;
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Image = global::HPMML.Properties.Resources.home;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HPMML.Properties.Resources.logop;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.btnStart);
            this.panelTop.Controls.Add(this.btnProcess);
            this.panelTop.Controls.Add(this.btnTrigger);
            this.panelTop.Controls.Add(this.pbStt);
            this.panelTop.Controls.Add(this.btnConnect);
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Image = global::HPMML.Properties.Resources.start;
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnProcess
            // 
            resources.ApplyResources(this.btnProcess, "btnProcess");
            this.btnProcess.Image = global::HPMML.Properties.Resources.Process;
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnTrigger
            // 
            resources.ApplyResources(this.btnTrigger, "btnTrigger");
            this.btnTrigger.Image = global::HPMML.Properties.Resources.pic;
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // pbStt
            // 
            this.pbStt.Image = global::HPMML.Properties.Resources.stop;
            resources.ApplyResources(this.pbStt, "pbStt");
            this.pbStt.Name = "pbStt";
            this.pbStt.TabStop = false;
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Image = global::HPMML.Properties.Resources.link;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.cbPlc);
            this.panel6.Controls.Add(this.cbDevices);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lbFail);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.lbPass);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pbResult);
            this.panel6.Controls.Add(this.pbRaw);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // cbPlc
            // 
            this.cbPlc.FormattingEnabled = true;
            resources.ApplyResources(this.cbPlc, "cbPlc");
            this.cbPlc.Name = "cbPlc";
            // 
            // cbDevices
            // 
            this.cbDevices.FormattingEnabled = true;
            resources.ApplyResources(this.cbDevices, "cbDevices");
            this.cbDevices.Name = "cbDevices";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lbFail
            // 
            resources.ApplyResources(this.lbFail, "lbFail");
            this.lbFail.Name = "lbFail";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbPass
            // 
            resources.ApplyResources(this.lbPass, "lbPass");
            this.lbPass.Name = "lbPass";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbResult, "pbResult");
            this.pbResult.Name = "pbResult";
            this.pbResult.TabStop = false;
            // 
            // pbRaw
            // 
            this.pbRaw.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbRaw, "pbRaw");
            this.pbRaw.Name = "pbRaw";
            this.pbRaw.TabStop = false;
            // 
            // timerGetTrigger
            // 
            this.timerGetTrigger.Tick += new System.EventHandler(this.timerGetTrigger_Tick);
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStt)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.PictureBox pbRaw;
        private System.Windows.Forms.PictureBox pbStt;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbFail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbPlc;
        private System.Windows.Forms.Timer timerGetTrigger;
    }
}

