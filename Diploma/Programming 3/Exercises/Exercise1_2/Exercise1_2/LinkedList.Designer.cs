namespace Exercise1_2
{
    partial class LinkedList
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
            this.lstCarOutput = new System.Windows.Forms.ListBox();
            this.lbCarName = new System.Windows.Forms.Label();
            this.tbCarName = new System.Windows.Forms.TextBox();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbEnterNode = new System.Windows.Forms.Label();
            this.tbNodeName = new System.Windows.Forms.TextBox();
            this.btnAddBefore = new System.Windows.Forms.Button();
            this.btnAddAfter = new System.Windows.Forms.Button();
            this.tbNodeCount = new System.Windows.Forms.TextBox();
            this.lbNodeCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCarOutput
            // 
            this.lstCarOutput.FormattingEnabled = true;
            this.lstCarOutput.Location = new System.Drawing.Point(27, 36);
            this.lstCarOutput.Name = "lstCarOutput";
            this.lstCarOutput.Size = new System.Drawing.Size(120, 290);
            this.lstCarOutput.TabIndex = 0;
            this.lstCarOutput.SelectedIndexChanged += new System.EventHandler(this.lstCarOutput_SelectedIndexChanged);
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(172, 36);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(54, 13);
            this.lbCarName.TabIndex = 1;
            this.lbCarName.Text = "Car Name";
            // 
            // tbCarName
            // 
            this.tbCarName.Location = new System.Drawing.Point(175, 53);
            this.tbCarName.Name = "tbCarName";
            this.tbCarName.Size = new System.Drawing.Size(100, 20);
            this.tbCarName.TabIndex = 2;
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Location = new System.Drawing.Point(175, 80);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(75, 23);
            this.btnAddFirst.TabIndex = 3;
            this.btnAddFirst.Text = "Add First";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.Location = new System.Drawing.Point(175, 110);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(75, 23);
            this.btnAddLast.TabIndex = 4;
            this.btnAddLast.Text = "Add Last";
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(175, 140);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(175, 170);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbEnterNode
            // 
            this.lbEnterNode.AutoSize = true;
            this.lbEnterNode.Location = new System.Drawing.Point(302, 36);
            this.lbEnterNode.Name = "lbEnterNode";
            this.lbEnterNode.Size = new System.Drawing.Size(117, 13);
            this.lbEnterNode.TabIndex = 7;
            this.lbEnterNode.Text = "Enter Node (Car Name)";
            // 
            // tbNodeName
            // 
            this.tbNodeName.Location = new System.Drawing.Point(305, 53);
            this.tbNodeName.Name = "tbNodeName";
            this.tbNodeName.Size = new System.Drawing.Size(100, 20);
            this.tbNodeName.TabIndex = 8;
            // 
            // btnAddBefore
            // 
            this.btnAddBefore.Location = new System.Drawing.Point(305, 80);
            this.btnAddBefore.Name = "btnAddBefore";
            this.btnAddBefore.Size = new System.Drawing.Size(75, 23);
            this.btnAddBefore.TabIndex = 9;
            this.btnAddBefore.Text = "Add Before";
            this.btnAddBefore.UseVisualStyleBackColor = true;
            this.btnAddBefore.Click += new System.EventHandler(this.btnAddBefore_Click);
            // 
            // btnAddAfter
            // 
            this.btnAddAfter.Location = new System.Drawing.Point(305, 110);
            this.btnAddAfter.Name = "btnAddAfter";
            this.btnAddAfter.Size = new System.Drawing.Size(75, 23);
            this.btnAddAfter.TabIndex = 10;
            this.btnAddAfter.Text = "Add After";
            this.btnAddAfter.UseVisualStyleBackColor = true;
            this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
            // 
            // tbNodeCount
            // 
            this.tbNodeCount.Location = new System.Drawing.Point(305, 305);
            this.tbNodeCount.Name = "tbNodeCount";
            this.tbNodeCount.ReadOnly = true;
            this.tbNodeCount.Size = new System.Drawing.Size(100, 20);
            this.tbNodeCount.TabIndex = 11;
            // 
            // lbNodeCount
            // 
            this.lbNodeCount.AutoSize = true;
            this.lbNodeCount.Location = new System.Drawing.Point(305, 286);
            this.lbNodeCount.Name = "lbNodeCount";
            this.lbNodeCount.Size = new System.Drawing.Size(90, 13);
            this.lbNodeCount.TabIndex = 12;
            this.lbNodeCount.Text = "Number of Nodes";
            // 
            // LinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 366);
            this.Controls.Add(this.lbNodeCount);
            this.Controls.Add(this.tbNodeCount);
            this.Controls.Add(this.btnAddAfter);
            this.Controls.Add(this.btnAddBefore);
            this.Controls.Add(this.tbNodeName);
            this.Controls.Add(this.lbEnterNode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddLast);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.tbCarName);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lstCarOutput);
            this.Name = "LinkedList";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarOutput;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.TextBox tbCarName;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbEnterNode;
        private System.Windows.Forms.TextBox tbNodeName;
        private System.Windows.Forms.Button btnAddBefore;
        private System.Windows.Forms.Button btnAddAfter;
        private System.Windows.Forms.TextBox tbNodeCount;
        private System.Windows.Forms.Label lbNodeCount;
    }
}

