namespace MyFleet
{
    partial class MyFleet
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
            this.lbVehicle = new System.Windows.Forms.Label();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbHullType = new System.Windows.Forms.TextBox();
            this.tbBodyType = new System.Windows.Forms.TextBox();
            this.btnAddBoat = new System.Windows.Forms.Button();
            this.btnOverloadedBoat = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnOverloadedCar = new System.Windows.Forms.Button();
            this.lbMake = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbHullType = new System.Windows.Forms.Label();
            this.lbBodyType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNumEngines = new System.Windows.Forms.TextBox();
            this.tbEngineType = new System.Windows.Forms.TextBox();
            this.btnAddAirplane = new System.Windows.Forms.Button();
            this.btnOverloadedAirplane = new System.Windows.Forms.Button();
            this.lbnumEngines = new System.Windows.Forms.Label();
            this.lbEngineType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVehicle
            // 
            this.lbVehicle.AutoSize = true;
            this.lbVehicle.Location = new System.Drawing.Point(40, 15);
            this.lbVehicle.Name = "lbVehicle";
            this.lbVehicle.Size = new System.Drawing.Size(102, 13);
            this.lbVehicle.TabIndex = 0;
            this.lbVehicle.Text = "Vehicle (Base Type)";
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(59, 43);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(100, 20);
            this.tbMake.TabIndex = 1;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(59, 69);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 2;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(59, 95);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 3;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 140);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(226, 173);
            this.lstOutput.TabIndex = 4;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(83, 19);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(100, 20);
            this.tbLength.TabIndex = 7;
            // 
            // tbHullType
            // 
            this.tbHullType.Location = new System.Drawing.Point(83, 45);
            this.tbHullType.Name = "tbHullType";
            this.tbHullType.Size = new System.Drawing.Size(100, 20);
            this.tbHullType.TabIndex = 8;
            // 
            // tbBodyType
            // 
            this.tbBodyType.Location = new System.Drawing.Point(83, 19);
            this.tbBodyType.Name = "tbBodyType";
            this.tbBodyType.Size = new System.Drawing.Size(100, 20);
            this.tbBodyType.TabIndex = 9;
            // 
            // btnAddBoat
            // 
            this.btnAddBoat.Location = new System.Drawing.Point(189, 17);
            this.btnAddBoat.Name = "btnAddBoat";
            this.btnAddBoat.Size = new System.Drawing.Size(75, 23);
            this.btnAddBoat.TabIndex = 13;
            this.btnAddBoat.Text = "Add Boat";
            this.btnAddBoat.UseVisualStyleBackColor = true;
            this.btnAddBoat.Click += new System.EventHandler(this.btnAddBoat_Click);
            // 
            // btnOverloadedBoat
            // 
            this.btnOverloadedBoat.Location = new System.Drawing.Point(189, 43);
            this.btnOverloadedBoat.Name = "btnOverloadedBoat";
            this.btnOverloadedBoat.Size = new System.Drawing.Size(75, 23);
            this.btnOverloadedBoat.TabIndex = 14;
            this.btnOverloadedBoat.Text = "Overloaded";
            this.btnOverloadedBoat.UseVisualStyleBackColor = true;
            this.btnOverloadedBoat.Click += new System.EventHandler(this.btnOverloadedBoat_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(189, 17);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 15;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnOverloadedCar
            // 
            this.btnOverloadedCar.Location = new System.Drawing.Point(189, 43);
            this.btnOverloadedCar.Name = "btnOverloadedCar";
            this.btnOverloadedCar.Size = new System.Drawing.Size(75, 23);
            this.btnOverloadedCar.TabIndex = 16;
            this.btnOverloadedCar.Text = "Overloaded";
            this.btnOverloadedCar.UseVisualStyleBackColor = true;
            this.btnOverloadedCar.Click += new System.EventHandler(this.btnOverloadedCar_Click);
            // 
            // lbMake
            // 
            this.lbMake.AutoSize = true;
            this.lbMake.Location = new System.Drawing.Point(19, 46);
            this.lbMake.Name = "lbMake";
            this.lbMake.Size = new System.Drawing.Size(34, 13);
            this.lbMake.TabIndex = 17;
            this.lbMake.Text = "Make";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(19, 72);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(36, 13);
            this.lbModel.TabIndex = 18;
            this.lbModel.Text = "Model";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(19, 98);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(29, 13);
            this.lbYear.TabIndex = 19;
            this.lbYear.Text = "Year";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(37, 22);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(40, 13);
            this.lbLength.TabIndex = 25;
            this.lbLength.Text = "Length";
            // 
            // lbHullType
            // 
            this.lbHullType.AutoSize = true;
            this.lbHullType.Location = new System.Drawing.Point(25, 48);
            this.lbHullType.Name = "lbHullType";
            this.lbHullType.Size = new System.Drawing.Size(52, 13);
            this.lbHullType.TabIndex = 26;
            this.lbHullType.Text = "Hull Type";
            // 
            // lbBodyType
            // 
            this.lbBodyType.AutoSize = true;
            this.lbBodyType.Location = new System.Drawing.Point(19, 22);
            this.lbBodyType.Name = "lbBodyType";
            this.lbBodyType.Size = new System.Drawing.Size(58, 13);
            this.lbBodyType.TabIndex = 27;
            this.lbBodyType.Text = "Body Type";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lbnumEngines);
            this.groupBox1.Controls.Add(this.tbNumEngines);
            this.groupBox1.Controls.Add(this.tbEngineType);
            this.groupBox1.Controls.Add(this.btnAddAirplane);
            this.groupBox1.Controls.Add(this.lbEngineType);
            this.groupBox1.Controls.Add(this.btnOverloadedAirplane);
            this.groupBox1.Location = new System.Drawing.Point(294, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 79);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Airplane";
            // 
            // tbNumEngines
            // 
            this.tbNumEngines.Location = new System.Drawing.Point(83, 20);
            this.tbNumEngines.Name = "tbNumEngines";
            this.tbNumEngines.Size = new System.Drawing.Size(100, 20);
            this.tbNumEngines.TabIndex = 5;
            // 
            // tbEngineType
            // 
            this.tbEngineType.Location = new System.Drawing.Point(83, 46);
            this.tbEngineType.Name = "tbEngineType";
            this.tbEngineType.Size = new System.Drawing.Size(100, 20);
            this.tbEngineType.TabIndex = 6;
            // 
            // btnAddAirplane
            // 
            this.btnAddAirplane.Location = new System.Drawing.Point(189, 19);
            this.btnAddAirplane.Name = "btnAddAirplane";
            this.btnAddAirplane.Size = new System.Drawing.Size(75, 23);
            this.btnAddAirplane.TabIndex = 11;
            this.btnAddAirplane.Text = "Add Airplane";
            this.btnAddAirplane.UseVisualStyleBackColor = true;
            this.btnAddAirplane.Click += new System.EventHandler(this.btnAddAirplane_Click);
            // 
            // btnOverloadedAirplane
            // 
            this.btnOverloadedAirplane.Location = new System.Drawing.Point(189, 44);
            this.btnOverloadedAirplane.Name = "btnOverloadedAirplane";
            this.btnOverloadedAirplane.Size = new System.Drawing.Size(75, 23);
            this.btnOverloadedAirplane.TabIndex = 12;
            this.btnOverloadedAirplane.Text = "Overloaded";
            this.btnOverloadedAirplane.UseVisualStyleBackColor = true;
            this.btnOverloadedAirplane.Click += new System.EventHandler(this.btnOverloadedAirplane_Click);
            // 
            // lbnumEngines
            // 
            this.lbnumEngines.AutoSize = true;
            this.lbnumEngines.Location = new System.Drawing.Point(7, 23);
            this.lbnumEngines.Name = "lbnumEngines";
            this.lbnumEngines.Size = new System.Drawing.Size(70, 13);
            this.lbnumEngines.TabIndex = 23;
            this.lbnumEngines.Text = "Num Engines";
            // 
            // lbEngineType
            // 
            this.lbEngineType.AutoSize = true;
            this.lbEngineType.Location = new System.Drawing.Point(10, 49);
            this.lbEngineType.Name = "lbEngineType";
            this.lbEngineType.Size = new System.Drawing.Size(67, 13);
            this.lbEngineType.TabIndex = 24;
            this.lbEngineType.Text = "Engine Type";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.tbLength);
            this.groupBox2.Controls.Add(this.tbHullType);
            this.groupBox2.Controls.Add(this.btnAddBoat);
            this.groupBox2.Controls.Add(this.btnOverloadedBoat);
            this.groupBox2.Controls.Add(this.lbHullType);
            this.groupBox2.Controls.Add(this.lbLength);
            this.groupBox2.Location = new System.Drawing.Point(294, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 80);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boat";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.tbBodyType);
            this.groupBox3.Controls.Add(this.btnAddCar);
            this.groupBox3.Controls.Add(this.btnOverloadedCar);
            this.groupBox3.Controls.Add(this.lbBodyType);
            this.groupBox3.Location = new System.Drawing.Point(294, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 79);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Car";
            // 
            // MyFleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 339);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbMake);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbMake);
            this.Controls.Add(this.lbVehicle);
            this.Name = "MyFleet";
            this.Text = "My Fleet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVehicle;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbHullType;
        private System.Windows.Forms.TextBox tbBodyType;
        private System.Windows.Forms.Button btnAddBoat;
        private System.Windows.Forms.Button btnOverloadedBoat;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnOverloadedCar;
        private System.Windows.Forms.Label lbMake;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbHullType;
        private System.Windows.Forms.Label lbBodyType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbnumEngines;
        private System.Windows.Forms.TextBox tbNumEngines;
        private System.Windows.Forms.TextBox tbEngineType;
        private System.Windows.Forms.Button btnAddAirplane;
        private System.Windows.Forms.Label lbEngineType;
        private System.Windows.Forms.Button btnOverloadedAirplane;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

