namespace MyBooks
{
    partial class MyBooksForm
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(66, 32);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 0;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(66, 59);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(100, 20);
            this.tbAuthor.TabIndex = 1;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(66, 86);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 2;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(66, 113);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbPublisher.TabIndex = 3;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(66, 139);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 23);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(30, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(30, 13);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Title:";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(19, 62);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(41, 13);
            this.lbAuthor.TabIndex = 6;
            this.lbAuthor.Text = "Author:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(27, 89);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(33, 13);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Date:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(7, 116);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(53, 13);
            this.lbPublisher.TabIndex = 8;
            this.lbPublisher.Text = "Publisher:";
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(188, 32);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(274, 147);
            this.lstOutput.TabIndex = 9;
            // 
            // MyBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 219);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.tbTitle);
            this.Name = "MyBooksForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

