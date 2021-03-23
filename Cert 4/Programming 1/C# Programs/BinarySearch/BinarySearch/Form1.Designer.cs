namespace BinarySearch
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
            this.lstOutPut = new System.Windows.Forms.ListBox();
            this.btnSortAndShow = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstOutPut
            // 
            this.lstOutPut.FormattingEnabled = true;
            this.lstOutPut.ItemHeight = 16;
            this.lstOutPut.Location = new System.Drawing.Point(154, 176);
            this.lstOutPut.Name = "lstOutPut";
            this.lstOutPut.Size = new System.Drawing.Size(149, 228);
            this.lstOutPut.TabIndex = 0;
            // 
            // btnSortAndShow
            // 
            this.btnSortAndShow.Location = new System.Drawing.Point(133, 87);
            this.btnSortAndShow.Name = "btnSortAndShow";
            this.btnSortAndShow.Size = new System.Drawing.Size(114, 23);
            this.btnSortAndShow.TabIndex = 1;
            this.btnSortAndShow.Text = "Sort and Show";
            this.btnSortAndShow.UseVisualStyleBackColor = true;
            this.btnSortAndShow.Click += new System.EventHandler(this.btnSortAndShow_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(297, 86);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(478, 176);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 22);
            this.tbSearch.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSortAndShow);
            this.Controls.Add(this.lstOutPut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutPut;
        private System.Windows.Forms.Button btnSortAndShow;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

