namespace AT2_Project
{
    partial class ArduinoControlSuite_V1
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
            this.grpbComPort = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.grpbMoodLight = new System.Windows.Forms.GroupBox();
            this.radOff = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.tbOutsideTemp = new System.Windows.Forms.TextBox();
            this.tbInsideTemp = new System.Windows.Forms.TextBox();
            this.tbInsideHumidity = new System.Windows.Forms.TextBox();
            this.cmbTempMax = new System.Windows.Forms.ComboBox();
            this.btnTempMax = new System.Windows.Forms.Button();
            this.btnRedLedToggle = new System.Windows.Forms.Button();
            this.lbOutsideTemp = new System.Windows.Forms.Label();
            this.lbInsideTemp = new System.Windows.Forms.Label();
            this.lbInsideHumidity = new System.Windows.Forms.Label();
            this.grpbComPort.SuspendLayout();
            this.grpbMoodLight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbComPort
            // 
            this.grpbComPort.Controls.Add(this.btnConnect);
            this.grpbComPort.Controls.Add(this.cmbComPort);
            this.grpbComPort.Location = new System.Drawing.Point(12, 12);
            this.grpbComPort.Name = "grpbComPort";
            this.grpbComPort.Size = new System.Drawing.Size(89, 81);
            this.grpbComPort.TabIndex = 0;
            this.grpbComPort.TabStop = false;
            this.grpbComPort.Text = "Com Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 48);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(7, 20);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(75, 21);
            this.cmbComPort.TabIndex = 0;
            // 
            // grpbMoodLight
            // 
            this.grpbMoodLight.Controls.Add(this.radOff);
            this.grpbMoodLight.Controls.Add(this.radBlue);
            this.grpbMoodLight.Controls.Add(this.radGreen);
            this.grpbMoodLight.Controls.Add(this.radRed);
            this.grpbMoodLight.Location = new System.Drawing.Point(12, 100);
            this.grpbMoodLight.Name = "grpbMoodLight";
            this.grpbMoodLight.Size = new System.Drawing.Size(89, 116);
            this.grpbMoodLight.TabIndex = 1;
            this.grpbMoodLight.TabStop = false;
            this.grpbMoodLight.Text = "Mood Light";
            // 
            // radOff
            // 
            this.radOff.AutoSize = true;
            this.radOff.Location = new System.Drawing.Point(7, 92);
            this.radOff.Name = "radOff";
            this.radOff.Size = new System.Drawing.Size(39, 17);
            this.radOff.TabIndex = 3;
            this.radOff.TabStop = true;
            this.radOff.Text = "Off";
            this.radOff.UseVisualStyleBackColor = true;
            this.radOff.CheckedChanged += new System.EventHandler(this.radOff_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(7, 68);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(7, 44);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(7, 20);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // tbOutsideTemp
            // 
            this.tbOutsideTemp.Location = new System.Drawing.Point(244, 24);
            this.tbOutsideTemp.Name = "tbOutsideTemp";
            this.tbOutsideTemp.ReadOnly = true;
            this.tbOutsideTemp.Size = new System.Drawing.Size(100, 20);
            this.tbOutsideTemp.TabIndex = 2;
            // 
            // tbInsideTemp
            // 
            this.tbInsideTemp.Location = new System.Drawing.Point(244, 51);
            this.tbInsideTemp.Name = "tbInsideTemp";
            this.tbInsideTemp.ReadOnly = true;
            this.tbInsideTemp.Size = new System.Drawing.Size(100, 20);
            this.tbInsideTemp.TabIndex = 3;
            // 
            // tbInsideHumidity
            // 
            this.tbInsideHumidity.Location = new System.Drawing.Point(244, 78);
            this.tbInsideHumidity.Name = "tbInsideHumidity";
            this.tbInsideHumidity.ReadOnly = true;
            this.tbInsideHumidity.Size = new System.Drawing.Size(100, 20);
            this.tbInsideHumidity.TabIndex = 4;
            // 
            // cmbTempMax
            // 
            this.cmbTempMax.FormattingEnabled = true;
            this.cmbTempMax.Location = new System.Drawing.Point(244, 112);
            this.cmbTempMax.Name = "cmbTempMax";
            this.cmbTempMax.Size = new System.Drawing.Size(100, 21);
            this.cmbTempMax.TabIndex = 5;
            // 
            // btnTempMax
            // 
            this.btnTempMax.Location = new System.Drawing.Point(163, 110);
            this.btnTempMax.Name = "btnTempMax";
            this.btnTempMax.Size = new System.Drawing.Size(75, 23);
            this.btnTempMax.TabIndex = 6;
            this.btnTempMax.Text = "Temp Max";
            this.btnTempMax.UseVisualStyleBackColor = true;
            this.btnTempMax.Click += new System.EventHandler(this.btnTempMax_Click);
            // 
            // btnRedLedToggle
            // 
            this.btnRedLedToggle.BackColor = System.Drawing.Color.Red;
            this.btnRedLedToggle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRedLedToggle.Location = new System.Drawing.Point(132, 160);
            this.btnRedLedToggle.Name = "btnRedLedToggle";
            this.btnRedLedToggle.Size = new System.Drawing.Size(212, 56);
            this.btnRedLedToggle.TabIndex = 7;
            this.btnRedLedToggle.Text = "Red LED Toggle";
            this.btnRedLedToggle.UseVisualStyleBackColor = false;
            this.btnRedLedToggle.Click += new System.EventHandler(this.btnRedLedToggle_Click);
            // 
            // lbOutsideTemp
            // 
            this.lbOutsideTemp.AutoSize = true;
            this.lbOutsideTemp.Location = new System.Drawing.Point(129, 27);
            this.lbOutsideTemp.Name = "lbOutsideTemp";
            this.lbOutsideTemp.Size = new System.Drawing.Size(109, 13);
            this.lbOutsideTemp.TabIndex = 8;
            this.lbOutsideTemp.Text = "Outside Temp (LM35)";
            // 
            // lbInsideTemp
            // 
            this.lbInsideTemp.AutoSize = true;
            this.lbInsideTemp.Location = new System.Drawing.Point(129, 54);
            this.lbInsideTemp.Name = "lbInsideTemp";
            this.lbInsideTemp.Size = new System.Drawing.Size(109, 13);
            this.lbInsideTemp.TabIndex = 9;
            this.lbInsideTemp.Text = "Inside Temp (DHT11)";
            // 
            // lbInsideHumidity
            // 
            this.lbInsideHumidity.AutoSize = true;
            this.lbInsideHumidity.Location = new System.Drawing.Point(116, 81);
            this.lbInsideHumidity.Name = "lbInsideHumidity";
            this.lbInsideHumidity.Size = new System.Drawing.Size(122, 13);
            this.lbInsideHumidity.TabIndex = 10;
            this.lbInsideHumidity.Text = "Inside Humidity (DHT11)";
            // 
            // ArduinoControlSuite_V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 228);
            this.Controls.Add(this.lbInsideHumidity);
            this.Controls.Add(this.lbInsideTemp);
            this.Controls.Add(this.lbOutsideTemp);
            this.Controls.Add(this.btnRedLedToggle);
            this.Controls.Add(this.btnTempMax);
            this.Controls.Add(this.cmbTempMax);
            this.Controls.Add(this.tbInsideHumidity);
            this.Controls.Add(this.tbInsideTemp);
            this.Controls.Add(this.tbOutsideTemp);
            this.Controls.Add(this.grpbMoodLight);
            this.Controls.Add(this.grpbComPort);
            this.Name = "ArduinoControlSuite_V1";
            this.Text = "Arduino Control Suite";
            this.grpbComPort.ResumeLayout(false);
            this.grpbMoodLight.ResumeLayout(false);
            this.grpbMoodLight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbComPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.GroupBox grpbMoodLight;
        private System.Windows.Forms.RadioButton radOff;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.TextBox tbOutsideTemp;
        private System.Windows.Forms.TextBox tbInsideTemp;
        private System.Windows.Forms.TextBox tbInsideHumidity;
        private System.Windows.Forms.ComboBox cmbTempMax;
        private System.Windows.Forms.Button btnTempMax;
        private System.Windows.Forms.Button btnRedLedToggle;
        private System.Windows.Forms.Label lbOutsideTemp;
        private System.Windows.Forms.Label lbInsideTemp;
        private System.Windows.Forms.Label lbInsideHumidity;
    }
}

