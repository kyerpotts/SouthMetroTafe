namespace Music_Player
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.wmpMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPlayFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lstSongOutput = new System.Windows.Forms.ListBox();
            this.btnLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpMediaPlayer
            // 
            this.wmpMediaPlayer.Enabled = true;
            this.wmpMediaPlayer.Location = new System.Drawing.Point(195, 12);
            this.wmpMediaPlayer.Name = "wmpMediaPlayer";
            this.wmpMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMediaPlayer.OcxState")));
            this.wmpMediaPlayer.Size = new System.Drawing.Size(274, 173);
            this.wmpMediaPlayer.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(38, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPlayFirst
            // 
            this.btnPlayFirst.Location = new System.Drawing.Point(38, 72);
            this.btnPlayFirst.Name = "btnPlayFirst";
            this.btnPlayFirst.Size = new System.Drawing.Size(75, 23);
            this.btnPlayFirst.TabIndex = 3;
            this.btnPlayFirst.Text = "First";
            this.btnPlayFirst.UseVisualStyleBackColor = true;
            this.btnPlayFirst.Click += new System.EventHandler(this.btnPlayFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(38, 102);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(38, 132);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lstSongOutput
            // 
            this.lstSongOutput.FormattingEnabled = true;
            this.lstSongOutput.Location = new System.Drawing.Point(38, 203);
            this.lstSongOutput.Name = "lstSongOutput";
            this.lstSongOutput.Size = new System.Drawing.Size(431, 121);
            this.lstSongOutput.TabIndex = 6;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(38, 162);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 343);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.lstSongOutput);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnPlayFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.wmpMediaPlayer);
            this.Name = "MusicPlayer";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.wmpMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpMediaPlayer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPlayFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lstSongOutput;
        private System.Windows.Forms.Button btnLast;
    }
}

