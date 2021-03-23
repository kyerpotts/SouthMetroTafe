namespace Exercise1_1
{
    partial class Revision
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbStudent = new System.Windows.Forms.TextBox();
            this.lbAddStudent = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(25, 22);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(144, 251);
            this.lstStudents.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbStudent
            // 
            this.tbStudent.Location = new System.Drawing.Point(190, 124);
            this.tbStudent.Name = "tbStudent";
            this.tbStudent.Size = new System.Drawing.Size(100, 20);
            this.tbStudent.TabIndex = 2;
            // 
            // lbAddStudent
            // 
            this.lbAddStudent.AutoSize = true;
            this.lbAddStudent.Location = new System.Drawing.Point(187, 108);
            this.lbAddStudent.Name = "lbAddStudent";
            this.lbAddStudent.Size = new System.Drawing.Size(111, 13);
            this.lbAddStudent.TabIndex = 3;
            this.lbAddStudent.Text = "Add/Remove Student";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(190, 163);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(190, 221);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort (asc)";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(190, 250);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 23);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.Text = "Sort (desc)";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(190, 51);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 299);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lbAddStudent);
            this.Controls.Add(this.tbStudent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstStudents);
            this.Name = "Revision";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbStudent;
        private System.Windows.Forms.Label lbAddStudent;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnRemove;
    }
}

