namespace GUIDemos
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.tbOutPut = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.tbProducts = new System.Windows.Forms.TextBox();
            this.cmbFish = new System.Windows.Forms.ComboBox();
            this.lstFish = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.grpColours = new System.Windows.Forms.GroupBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.btnColour = new System.Windows.Forms.Button();
            this.grpShoppingList = new System.Windows.Forms.GroupBox();
            this.tbShoppingList = new System.Windows.Forms.TextBox();
            this.chkMilk = new System.Windows.Forms.CheckBox();
            this.chkBread = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkApples = new System.Windows.Forms.CheckBox();
            this.btnShoppingList = new System.Windows.Forms.Button();
            this.grpColours.SuspendLayout();
            this.grpShoppingList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 1;
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(263, 10);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(103, 27);
            this.btnSayHello.TabIndex = 2;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // tbOutPut
            // 
            this.tbOutPut.Location = new System.Drawing.Point(414, 12);
            this.tbOutPut.Name = "tbOutPut";
            this.tbOutPut.ReadOnly = true;
            this.tbOutPut.Size = new System.Drawing.Size(309, 22);
            this.tbOutPut.TabIndex = 3;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "Hammer",
            "Drill",
            "Saw"});
            this.cmbProduct.Location = new System.Drawing.Point(15, 121);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(234, 24);
            this.cmbProduct.TabIndex = 4;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // tbProducts
            // 
            this.tbProducts.Location = new System.Drawing.Point(15, 205);
            this.tbProducts.Multiline = true;
            this.tbProducts.Name = "tbProducts";
            this.tbProducts.Size = new System.Drawing.Size(351, 161);
            this.tbProducts.TabIndex = 5;
            // 
            // cmbFish
            // 
            this.cmbFish.FormattingEnabled = true;
            this.cmbFish.Location = new System.Drawing.Point(433, 205);
            this.cmbFish.Name = "cmbFish";
            this.cmbFish.Size = new System.Drawing.Size(121, 24);
            this.cmbFish.TabIndex = 6;
            // 
            // lstFish
            // 
            this.lstFish.FormattingEnabled = true;
            this.lstFish.ItemHeight = 16;
            this.lstFish.Location = new System.Drawing.Point(433, 267);
            this.lstFish.Name = "lstFish";
            this.lstFish.Size = new System.Drawing.Size(265, 100);
            this.lstFish.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(560, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(433, 236);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(560, 235);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 10;
            this.btnLoop.Text = "Loop Over List";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // grpColours
            // 
            this.grpColours.Controls.Add(this.radWhite);
            this.grpColours.Controls.Add(this.radBlue);
            this.grpColours.Controls.Add(this.radRed);
            this.grpColours.Location = new System.Drawing.Point(15, 396);
            this.grpColours.Name = "grpColours";
            this.grpColours.Size = new System.Drawing.Size(200, 100);
            this.grpColours.TabIndex = 11;
            this.grpColours.TabStop = false;
            this.grpColours.Text = "Colours";
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(77, 11);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(55, 21);
            this.radRed.TabIndex = 0;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(77, 39);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(57, 21);
            this.radBlue.TabIndex = 1;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.Location = new System.Drawing.Point(77, 67);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(65, 21);
            this.radWhite.TabIndex = 2;
            this.radWhite.Text = "White";
            this.radWhite.UseVisualStyleBackColor = true;
            // 
            // btnColour
            // 
            this.btnColour.Location = new System.Drawing.Point(221, 435);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(122, 23);
            this.btnColour.TabIndex = 12;
            this.btnColour.Text = "Choose Colour";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // grpShoppingList
            // 
            this.grpShoppingList.Controls.Add(this.chkApples);
            this.grpShoppingList.Controls.Add(this.chkChicken);
            this.grpShoppingList.Controls.Add(this.chkBread);
            this.grpShoppingList.Controls.Add(this.chkMilk);
            this.grpShoppingList.Location = new System.Drawing.Point(433, 407);
            this.grpShoppingList.Name = "grpShoppingList";
            this.grpShoppingList.Size = new System.Drawing.Size(266, 100);
            this.grpShoppingList.TabIndex = 13;
            this.grpShoppingList.TabStop = false;
            this.grpShoppingList.Text = "Shopping List";
            // 
            // tbShoppingList
            // 
            this.tbShoppingList.Location = new System.Drawing.Point(705, 407);
            this.tbShoppingList.Multiline = true;
            this.tbShoppingList.Name = "tbShoppingList";
            this.tbShoppingList.Size = new System.Drawing.Size(110, 100);
            this.tbShoppingList.TabIndex = 14;
            // 
            // chkMilk
            // 
            this.chkMilk.AutoSize = true;
            this.chkMilk.Location = new System.Drawing.Point(22, 28);
            this.chkMilk.Name = "chkMilk";
            this.chkMilk.Size = new System.Drawing.Size(54, 21);
            this.chkMilk.TabIndex = 0;
            this.chkMilk.Text = "Milk";
            this.chkMilk.UseVisualStyleBackColor = true;
            // 
            // chkBread
            // 
            this.chkBread.AutoSize = true;
            this.chkBread.Location = new System.Drawing.Point(22, 56);
            this.chkBread.Name = "chkBread";
            this.chkBread.Size = new System.Drawing.Size(68, 21);
            this.chkBread.TabIndex = 1;
            this.chkBread.Text = "Bread";
            this.chkBread.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(131, 28);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(80, 21);
            this.chkChicken.TabIndex = 2;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkApples
            // 
            this.chkApples.AutoSize = true;
            this.chkApples.Location = new System.Drawing.Point(131, 57);
            this.chkApples.Name = "chkApples";
            this.chkApples.Size = new System.Drawing.Size(73, 21);
            this.chkApples.TabIndex = 3;
            this.chkApples.Text = "Apples";
            this.chkApples.UseVisualStyleBackColor = true;
            // 
            // btnShoppingList
            // 
            this.btnShoppingList.Location = new System.Drawing.Point(433, 524);
            this.btnShoppingList.Name = "btnShoppingList";
            this.btnShoppingList.Size = new System.Drawing.Size(75, 23);
            this.btnShoppingList.TabIndex = 15;
            this.btnShoppingList.Text = "Write List";
            this.btnShoppingList.UseVisualStyleBackColor = true;
            this.btnShoppingList.Click += new System.EventHandler(this.btnShoppingList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 628);
            this.Controls.Add(this.btnShoppingList);
            this.Controls.Add(this.tbShoppingList);
            this.Controls.Add(this.grpShoppingList);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.grpColours);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstFish);
            this.Controls.Add(this.cmbFish);
            this.Controls.Add(this.tbProducts);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.tbOutPut);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpColours.ResumeLayout(false);
            this.grpColours.PerformLayout();
            this.grpShoppingList.ResumeLayout(false);
            this.grpShoppingList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.TextBox tbOutPut;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.TextBox tbProducts;
        private System.Windows.Forms.ComboBox cmbFish;
        private System.Windows.Forms.ListBox lstFish;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.GroupBox grpColours;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.GroupBox grpShoppingList;
        private System.Windows.Forms.CheckBox chkApples;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkBread;
        private System.Windows.Forms.CheckBox chkMilk;
        private System.Windows.Forms.TextBox tbShoppingList;
        private System.Windows.Forms.Button btnShoppingList;
    }
}

