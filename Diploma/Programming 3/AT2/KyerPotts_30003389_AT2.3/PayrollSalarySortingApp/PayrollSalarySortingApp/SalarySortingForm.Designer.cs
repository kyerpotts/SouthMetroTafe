namespace PayrollSalarySortingApp
{
    partial class SalarySortingForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnRadixSort = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTestBS = new System.Windows.Forms.Button();
            this.btnTestMS = new System.Windows.Forms.Button();
            this.btnTestRS = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 16);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(12, 45);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.btnBubbleSort.TabIndex = 1;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(12, 74);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(75, 23);
            this.btnMergeSort.TabIndex = 2;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnRadixSort
            // 
            this.btnRadixSort.Location = new System.Drawing.Point(12, 103);
            this.btnRadixSort.Name = "btnRadixSort";
            this.btnRadixSort.Size = new System.Drawing.Size(75, 23);
            this.btnRadixSort.TabIndex = 3;
            this.btnRadixSort.Text = "Radix Sort";
            this.btnRadixSort.UseVisualStyleBackColor = true;
            this.btnRadixSort.Click += new System.EventHandler(this.btnRadixSort_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(102, 16);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(166, 316);
            this.lstOutput.TabIndex = 4;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(280, 19);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(33, 13);
            this.lbTimer.TabIndex = 5;
            this.lbTimer.Text = "Timer";
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(321, 16);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(100, 20);
            this.tbTimer.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(435, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnTestBS
            // 
            this.btnTestBS.Location = new System.Drawing.Point(13, 160);
            this.btnTestBS.Name = "btnTestBS";
            this.btnTestBS.Size = new System.Drawing.Size(75, 23);
            this.btnTestBS.TabIndex = 8;
            this.btnTestBS.Text = "Test BS";
            this.btnTestBS.UseVisualStyleBackColor = true;
            this.btnTestBS.Click += new System.EventHandler(this.btnTestBS_Click);
            // 
            // btnTestMS
            // 
            this.btnTestMS.Location = new System.Drawing.Point(13, 190);
            this.btnTestMS.Name = "btnTestMS";
            this.btnTestMS.Size = new System.Drawing.Size(75, 23);
            this.btnTestMS.TabIndex = 9;
            this.btnTestMS.Text = "Test MS";
            this.btnTestMS.UseVisualStyleBackColor = true;
            this.btnTestMS.Click += new System.EventHandler(this.btnTestMS_Click);
            // 
            // btnTestRS
            // 
            this.btnTestRS.Location = new System.Drawing.Point(13, 220);
            this.btnTestRS.Name = "btnTestRS";
            this.btnTestRS.Size = new System.Drawing.Size(75, 23);
            this.btnTestRS.TabIndex = 10;
            this.btnTestRS.Text = "Test RS";
            this.btnTestRS.UseVisualStyleBackColor = true;
            this.btnTestRS.Click += new System.EventHandler(this.btnTestRS_Click);
            // 
            // SalarySortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 379);
            this.Controls.Add(this.btnTestRS);
            this.Controls.Add(this.btnTestMS);
            this.Controls.Add(this.btnTestBS);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnRadixSort);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnGenerate);
            this.Name = "SalarySortingForm";
            this.Text = "Salary Sorting Application";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnRadixSort;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnTestBS;
        private System.Windows.Forms.Button btnTestMS;
        private System.Windows.Forms.Button btnTestRS;
    }
}

