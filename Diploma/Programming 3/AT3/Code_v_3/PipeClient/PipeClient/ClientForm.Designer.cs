namespace PipeClient
{
    partial class ClientForm
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.lbPipeName = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCreateUser = new System.Windows.Forms.Button();
            this.tbReceived = new System.Windows.Forms.TextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.LstOutput = new System.Windows.Forms.ListBox();
            this.BtnImportCSV = new System.Windows.Forms.Button();
            this.BtnShuffle = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.lbSearchMovies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPipeName
            // 
            this.tbPipeName.Location = new System.Drawing.Point(15, 25);
            this.tbPipeName.Name = "tbPipeName";
            this.tbPipeName.ReadOnly = true;
            this.tbPipeName.Size = new System.Drawing.Size(100, 20);
            this.tbPipeName.TabIndex = 0;
            this.tbPipeName.Text = "\\\\.\\pipe\\myNamedPipe";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(15, 51);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // lbPipeName
            // 
            this.lbPipeName.AutoSize = true;
            this.lbPipeName.Location = new System.Drawing.Point(12, 9);
            this.lbPipeName.Name = "lbPipeName";
            this.lbPipeName.Size = new System.Drawing.Size(62, 13);
            this.lbPipeName.TabIndex = 2;
            this.lbPipeName.Text = "Pipe Name:";
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(107, 94);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(100, 20);
            this.tbUserID.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(107, 121);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(150, 148);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreateUser
            // 
            this.BtnCreateUser.Location = new System.Drawing.Point(150, 178);
            this.BtnCreateUser.Name = "BtnCreateUser";
            this.BtnCreateUser.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateUser.TabIndex = 6;
            this.BtnCreateUser.Text = "Create User";
            this.BtnCreateUser.UseVisualStyleBackColor = true;
            this.BtnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // tbReceived
            // 
            this.tbReceived.Location = new System.Drawing.Point(12, 220);
            this.tbReceived.Multiline = true;
            this.tbReceived.Name = "tbReceived";
            this.tbReceived.ReadOnly = true;
            this.tbReceived.Size = new System.Drawing.Size(225, 218);
            this.tbReceived.TabIndex = 7;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(55, 97);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(46, 13);
            this.lbUserID.TabIndex = 8;
            this.lbUserID.Text = "User ID:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(45, 124);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password:";
            // 
            // LstOutput
            // 
            this.LstOutput.FormattingEnabled = true;
            this.LstOutput.Location = new System.Drawing.Point(265, 25);
            this.LstOutput.Name = "LstOutput";
            this.LstOutput.Size = new System.Drawing.Size(180, 407);
            this.LstOutput.TabIndex = 10;
            // 
            // BtnImportCSV
            // 
            this.BtnImportCSV.Enabled = false;
            this.BtnImportCSV.Location = new System.Drawing.Point(468, 38);
            this.BtnImportCSV.Name = "BtnImportCSV";
            this.BtnImportCSV.Size = new System.Drawing.Size(135, 47);
            this.BtnImportCSV.TabIndex = 11;
            this.BtnImportCSV.Text = "Import CSV";
            this.BtnImportCSV.UseVisualStyleBackColor = true;
            this.BtnImportCSV.Click += new System.EventHandler(this.BtnImportCSV_Click);
            // 
            // BtnShuffle
            // 
            this.BtnShuffle.Enabled = false;
            this.BtnShuffle.Location = new System.Drawing.Point(468, 90);
            this.BtnShuffle.Name = "BtnShuffle";
            this.BtnShuffle.Size = new System.Drawing.Size(135, 47);
            this.BtnShuffle.TabIndex = 12;
            this.BtnShuffle.Text = "Shuffle Data";
            this.BtnShuffle.UseVisualStyleBackColor = true;
            this.BtnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Enabled = false;
            this.BtnSort.Location = new System.Drawing.Point(468, 143);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(135, 47);
            this.BtnSort.TabIndex = 13;
            this.BtnSort.Text = "Sort Data";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(464, 274);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(135, 20);
            this.tbSearch.TabIndex = 14;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Location = new System.Drawing.Point(464, 300);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(135, 47);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lbSearchMovies
            // 
            this.lbSearchMovies.AutoSize = true;
            this.lbSearchMovies.Location = new System.Drawing.Point(461, 258);
            this.lbSearchMovies.Name = "lbSearchMovies";
            this.lbSearchMovies.Size = new System.Drawing.Size(78, 13);
            this.lbSearchMovies.TabIndex = 16;
            this.lbSearchMovies.Text = "Search Movies";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.lbSearchMovies);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnShuffle);
            this.Controls.Add(this.BtnImportCSV);
            this.Controls.Add(this.LstOutput);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.tbReceived);
            this.Controls.Add(this.BtnCreateUser);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lbPipeName);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.tbPipeName);
            this.Name = "ClientForm";
            this.Text = "PipeClient";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPipeName;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label lbPipeName;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCreateUser;
        private System.Windows.Forms.TextBox tbReceived;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.ListBox LstOutput;
        private System.Windows.Forms.Button BtnImportCSV;
        private System.Windows.Forms.Button BtnShuffle;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label lbSearchMovies;
    }
}

