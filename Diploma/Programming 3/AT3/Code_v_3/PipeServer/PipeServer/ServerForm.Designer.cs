namespace PipeServer
{
    partial class ServerForm
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
            this.tbPipeName = new System.Windows.Forms.TextBox();
            this.lbPipeName = new System.Windows.Forms.Label();
            this.BtnStartServer = new System.Windows.Forms.Button();
            this.tbReceived = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPipeName
            // 
            this.tbPipeName.Location = new System.Drawing.Point(36, 30);
            this.tbPipeName.Name = "tbPipeName";
            this.tbPipeName.ReadOnly = true;
            this.tbPipeName.Size = new System.Drawing.Size(146, 20);
            this.tbPipeName.TabIndex = 0;
            this.tbPipeName.Text = "\\\\.\\pipe\\myNamedPipe";
            // 
            // lbPipeName
            // 
            this.lbPipeName.AutoSize = true;
            this.lbPipeName.Location = new System.Drawing.Point(36, 13);
            this.lbPipeName.Name = "lbPipeName";
            this.lbPipeName.Size = new System.Drawing.Size(62, 13);
            this.lbPipeName.TabIndex = 1;
            this.lbPipeName.Text = "Pipe Name:";
            // 
            // BtnStartServer
            // 
            this.BtnStartServer.Location = new System.Drawing.Point(36, 57);
            this.BtnStartServer.Name = "BtnStartServer";
            this.BtnStartServer.Size = new System.Drawing.Size(75, 23);
            this.BtnStartServer.TabIndex = 2;
            this.BtnStartServer.Text = "Start Server";
            this.BtnStartServer.UseVisualStyleBackColor = true;
            this.BtnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // tbReceived
            // 
            this.tbReceived.Location = new System.Drawing.Point(36, 86);
            this.tbReceived.Multiline = true;
            this.tbReceived.Name = "tbReceived";
            this.tbReceived.ReadOnly = true;
            this.tbReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReceived.Size = new System.Drawing.Size(243, 321);
            this.tbReceived.TabIndex = 3;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 423);
            this.Controls.Add(this.tbReceived);
            this.Controls.Add(this.BtnStartServer);
            this.Controls.Add(this.lbPipeName);
            this.Controls.Add(this.tbPipeName);
            this.Name = "ServerForm";
            this.Text = "PipeServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPipeName;
        private System.Windows.Forms.Label lbPipeName;
        private System.Windows.Forms.Button BtnStartServer;
        private System.Windows.Forms.TextBox tbReceived;
    }
}

