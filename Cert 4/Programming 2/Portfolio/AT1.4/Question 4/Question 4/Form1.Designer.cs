namespace Question_4
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
            this.tbPlatform = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbGameTitle = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.lbGameTitle = new System.Windows.Forms.Label();
            this.lbPLatform = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.Button();
            this.tbClear = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.Button();
            this.tbLoad = new System.Windows.Forms.Button();
            this.lstMyGames = new System.Windows.Forms.ListBox();
            this.lbMyGames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPlatform
            // 
            this.tbPlatform.Location = new System.Drawing.Point(119, 38);
            this.tbPlatform.Name = "tbPlatform";
            this.tbPlatform.Size = new System.Drawing.Size(100, 20);
            this.tbPlatform.TabIndex = 1;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(119, 64);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 20);
            this.tbGenre.TabIndex = 2;
            // 
            // tbGameTitle
            // 
            this.tbGameTitle.Location = new System.Drawing.Point(119, 12);
            this.tbGameTitle.Name = "tbGameTitle";
            this.tbGameTitle.Size = new System.Drawing.Size(100, 20);
            this.tbGameTitle.TabIndex = 0;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(119, 90);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbPublisher.TabIndex = 3;
            // 
            // lbGameTitle
            // 
            this.lbGameTitle.AutoSize = true;
            this.lbGameTitle.Location = new System.Drawing.Point(55, 15);
            this.lbGameTitle.Name = "lbGameTitle";
            this.lbGameTitle.Size = new System.Drawing.Size(58, 13);
            this.lbGameTitle.TabIndex = 10;
            this.lbGameTitle.Text = "Game Title";
            // 
            // lbPLatform
            // 
            this.lbPLatform.AutoSize = true;
            this.lbPLatform.Location = new System.Drawing.Point(68, 41);
            this.lbPLatform.Name = "lbPLatform";
            this.lbPLatform.Size = new System.Drawing.Size(45, 13);
            this.lbPLatform.TabIndex = 11;
            this.lbPLatform.Text = "Platform";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(77, 67);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(36, 13);
            this.lbGenre.TabIndex = 12;
            this.lbGenre.Text = "Genre";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(63, 93);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(50, 13);
            this.lbPublisher.TabIndex = 13;
            this.lbPublisher.Text = "Publisher";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(254, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(254, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(75, 23);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.Text = "Search";
            this.tbSearch.UseVisualStyleBackColor = true;
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // tbClear
            // 
            this.tbClear.Location = new System.Drawing.Point(254, 54);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(75, 23);
            this.tbClear.TabIndex = 6;
            this.tbClear.Text = "Clear";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.tbClear_Click);
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(254, 76);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(75, 23);
            this.tbSave.TabIndex = 7;
            this.tbSave.Text = "Save";
            this.tbSave.UseVisualStyleBackColor = true;
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // tbLoad
            // 
            this.tbLoad.Location = new System.Drawing.Point(254, 98);
            this.tbLoad.Name = "tbLoad";
            this.tbLoad.Size = new System.Drawing.Size(75, 23);
            this.tbLoad.TabIndex = 8;
            this.tbLoad.Text = "Load";
            this.tbLoad.UseVisualStyleBackColor = true;
            this.tbLoad.Click += new System.EventHandler(this.tbLoad_Click);
            // 
            // lstMyGames
            // 
            this.lstMyGames.FormattingEnabled = true;
            this.lstMyGames.Location = new System.Drawing.Point(37, 158);
            this.lstMyGames.Name = "lstMyGames";
            this.lstMyGames.Size = new System.Drawing.Size(292, 186);
            this.lstMyGames.TabIndex = 9;
            // 
            // lbMyGames
            // 
            this.lbMyGames.AutoSize = true;
            this.lbMyGames.Location = new System.Drawing.Point(37, 139);
            this.lbMyGames.Name = "lbMyGames";
            this.lbMyGames.Size = new System.Drawing.Size(57, 13);
            this.lbMyGames.TabIndex = 14;
            this.lbMyGames.Text = "My Games";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 369);
            this.Controls.Add(this.lbMyGames);
            this.Controls.Add(this.lstMyGames);
            this.Controls.Add(this.tbLoad);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbPLatform);
            this.Controls.Add(this.lbGameTitle);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbGameTitle);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbPlatform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlatform;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbGameTitle;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label lbGameTitle;
        private System.Windows.Forms.Label lbPLatform;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button tbSearch;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.Button tbLoad;
        private System.Windows.Forms.ListBox lstMyGames;
        private System.Windows.Forms.Label lbMyGames;
    }
}

