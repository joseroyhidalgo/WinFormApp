using System.Drawing;

namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.petsNameinput = new System.Windows.Forms.TextBox();
            this.LastnameInput = new System.Windows.Forms.TextBox();
            this.GivenNameInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RDrB = new System.Windows.Forms.RadioButton();
            this.RDrC = new System.Windows.Forms.RadioButton();
            this.RDrT = new System.Windows.Forms.RadioButton();
            this.rCheckup = new System.Windows.Forms.RadioButton();
            this.RDental = new System.Windows.Forms.RadioButton();
            this.RHospital = new System.Windows.Forms.RadioButton();
            this.RInnoculations = new System.Windows.Forms.RadioButton();
            this.RSpay = new System.Windows.Forms.RadioButton();
            this.RXray = new System.Windows.Forms.RadioButton();
            this.BookButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AnimalTypeCBO = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.comboBoxMins = new System.Windows.Forms.ComboBox();
            this.AMR = new System.Windows.Forms.RadioButton();
            this.PMR = new System.Windows.Forms.RadioButton();
            this.Output = new System.Windows.Forms.Label();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "BCN Veterinarian Services ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Owner\'s Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Given Name:";
            // 
            // petsNameinput
            // 
            this.petsNameinput.Location = new System.Drawing.Point(516, 115);
            this.petsNameinput.Name = "petsNameinput";
            this.petsNameinput.Size = new System.Drawing.Size(100, 20);
            this.petsNameinput.TabIndex = 4;
            // 
            // LastnameInput
            // 
            this.LastnameInput.Location = new System.Drawing.Point(182, 118);
            this.LastnameInput.Name = "LastnameInput";
            this.LastnameInput.Size = new System.Drawing.Size(100, 20);
            this.LastnameInput.TabIndex = 5;
            // 
            // GivenNameInput
            // 
            this.GivenNameInput.Location = new System.Drawing.Point(182, 156);
            this.GivenNameInput.Name = "GivenNameInput";
            this.GivenNameInput.Size = new System.Drawing.Size(100, 20);
            this.GivenNameInput.TabIndex = 6;
            this.GivenNameInput.TextChanged += new System.EventHandler(this.GivenNameInput_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select Day of Appointment";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // RDrB
            // 
            this.RDrB.AutoSize = true;
            this.RDrB.Location = new System.Drawing.Point(6, 20);
            this.RDrB.Name = "RDrB";
            this.RDrB.Size = new System.Drawing.Size(84, 17);
            this.RDrB.TabIndex = 12;
            this.RDrB.TabStop = true;
            this.RDrB.Text = "Dr.Bellissimo";
            this.RDrB.UseVisualStyleBackColor = true;
            this.RDrB.CheckedChanged += new System.EventHandler(this.RDrB_CheckedChanged);
            // 
            // RDrC
            // 
            this.RDrC.AutoSize = true;
            this.RDrC.Location = new System.Drawing.Point(6, 44);
            this.RDrC.Name = "RDrC";
            this.RDrC.Size = new System.Drawing.Size(76, 17);
            this.RDrC.TabIndex = 13;
            this.RDrC.TabStop = true;
            this.RDrC.Text = "Dr. Corbett";
            this.RDrC.UseVisualStyleBackColor = true;
            this.RDrC.CheckedChanged += new System.EventHandler(this.RDrC_CheckedChanged);
            // 
            // RDrT
            // 
            this.RDrT.AutoSize = true;
            this.RDrT.Location = new System.Drawing.Point(6, 67);
            this.RDrT.Name = "RDrT";
            this.RDrT.Size = new System.Drawing.Size(92, 17);
            this.RDrT.TabIndex = 14;
            this.RDrT.TabStop = true;
            this.RDrT.Text = "Dr.Tschernow";
            this.RDrT.UseVisualStyleBackColor = true;
            this.RDrT.CheckedChanged += new System.EventHandler(this.RDrT_CheckedChanged);
            // 
            // rCheckup
            // 
            this.rCheckup.AutoSize = true;
            this.rCheckup.Location = new System.Drawing.Point(10, 19);
            this.rCheckup.Name = "rCheckup";
            this.rCheckup.Size = new System.Drawing.Size(73, 17);
            this.rCheckup.TabIndex = 15;
            this.rCheckup.TabStop = true;
            this.rCheckup.Text = "Check-Up";
            this.rCheckup.UseVisualStyleBackColor = true;
            // 
            // RDental
            // 
            this.RDental.AutoSize = true;
            this.RDental.Location = new System.Drawing.Point(10, 42);
            this.RDental.Name = "RDental";
            this.RDental.Size = new System.Drawing.Size(56, 17);
            this.RDental.TabIndex = 16;
            this.RDental.TabStop = true;
            this.RDental.Text = "Dental";
            this.RDental.UseVisualStyleBackColor = true;
            // 
            // RHospital
            // 
            this.RHospital.AutoSize = true;
            this.RHospital.Location = new System.Drawing.Point(11, 67);
            this.RHospital.Name = "RHospital";
            this.RHospital.Size = new System.Drawing.Size(93, 17);
            this.RHospital.TabIndex = 17;
            this.RHospital.TabStop = true;
            this.RHospital.Text = "Hospitalization";
            this.RHospital.UseVisualStyleBackColor = true;
            // 
            // RInnoculations
            // 
            this.RInnoculations.AutoSize = true;
            this.RInnoculations.Location = new System.Drawing.Point(125, 67);
            this.RInnoculations.Name = "RInnoculations";
            this.RInnoculations.Size = new System.Drawing.Size(88, 17);
            this.RInnoculations.TabIndex = 18;
            this.RInnoculations.TabStop = true;
            this.RInnoculations.Text = "Innoculations";
            this.RInnoculations.UseVisualStyleBackColor = true;
            // 
            // RSpay
            // 
            this.RSpay.AutoSize = true;
            this.RSpay.Location = new System.Drawing.Point(125, 44);
            this.RSpay.Name = "RSpay";
            this.RSpay.Size = new System.Drawing.Size(86, 17);
            this.RSpay.TabIndex = 19;
            this.RSpay.TabStop = true;
            this.RSpay.Text = "Spay/Neuter";
            this.RSpay.UseVisualStyleBackColor = true;
            // 
            // RXray
            // 
            this.RXray.AutoSize = true;
            this.RXray.Location = new System.Drawing.Point(125, 20);
            this.RXray.Name = "RXray";
            this.RXray.Size = new System.Drawing.Size(59, 17);
            this.RXray.TabIndex = 20;
            this.RXray.TabStop = true;
            this.RXray.Text = "X-Rays";
            this.RXray.UseVisualStyleBackColor = true;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(65, 440);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(130, 23);
            this.BookButton.TabIndex = 21;
            this.BookButton.Text = "Book Appointment";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(65, 480);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(130, 23);
            this.NewButton.TabIndex = 22;
            this.NewButton.Text = "New Appointment";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(65, 524);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 23);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Given Name:";
            // 
            // AnimalTypeCBO
            // 
            this.AnimalTypeCBO.FormattingEnabled = true;
            this.AnimalTypeCBO.Items.AddRange(new object[] {
            "Bird",
            "Cat ",
            "Dog ",
            "Ferret",
            "Guinea Pig",
            "Rabbit",
            "Snake",
            "Turtle",
            "Other...",
            "",
            "Cats & exoctic pets like: birds"});
            this.AnimalTypeCBO.Location = new System.Drawing.Point(440, 154);
            this.AnimalTypeCBO.Name = "AnimalTypeCBO";
            this.AnimalTypeCBO.Size = new System.Drawing.Size(121, 21);
            this.AnimalTypeCBO.TabIndex = 25;
            this.AnimalTypeCBO.Text = "Select Animal Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pet\'s Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Select Time";
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxHour.Location = new System.Drawing.Point(440, 231);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHour.TabIndex = 28;
            this.comboBoxHour.Text = "Hour";
            // 
            // comboBoxMins
            // 
            this.comboBoxMins.FormattingEnabled = true;
            this.comboBoxMins.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMins.Location = new System.Drawing.Point(516, 231);
            this.comboBoxMins.Name = "comboBoxMins";
            this.comboBoxMins.Size = new System.Drawing.Size(49, 21);
            this.comboBoxMins.TabIndex = 29;
            this.comboBoxMins.Text = "Mins";
            this.comboBoxMins.SelectedIndexChanged += new System.EventHandler(this.comboBoxMins_SelectedIndexChanged);
            // 
            // AMR
            // 
            this.AMR.AutoSize = true;
            this.AMR.Location = new System.Drawing.Point(563, 205);
            this.AMR.Name = "AMR";
            this.AMR.Size = new System.Drawing.Size(44, 17);
            this.AMR.TabIndex = 30;
            this.AMR.TabStop = true;
            this.AMR.Text = "A.M";
            this.AMR.UseVisualStyleBackColor = true;
            // 
            // PMR
            // 
            this.PMR.AutoSize = true;
            this.PMR.Location = new System.Drawing.Point(627, 205);
            this.PMR.Name = "PMR";
            this.PMR.Size = new System.Drawing.Size(44, 17);
            this.PMR.TabIndex = 31;
            this.PMR.TabStop = true;
            this.PMR.Text = "P.M";
            this.PMR.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(343, 440);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(52, 13);
            this.Output.TabIndex = 33;
            this.Output.Text = "OUTPUT";
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.label6);
            this.groupBoxDoctor.Controls.Add(this.RDrB);
            this.groupBoxDoctor.Controls.Add(this.RDrC);
            this.groupBoxDoctor.Controls.Add(this.RDrT);
            this.groupBoxDoctor.Location = new System.Drawing.Point(357, 291);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(149, 94);
            this.groupBoxDoctor.TabIndex = 34;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Select Doctor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rCheckup);
            this.groupBox1.Controls.Add(this.RDental);
            this.groupBox1.Controls.Add(this.RHospital);
            this.groupBox1.Controls.Add(this.RXray);
            this.groupBox1.Controls.Add(this.RSpay);
            this.groupBox1.Controls.Add(this.RInnoculations);
            this.groupBox1.Location = new System.Drawing.Point(512, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 94);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Service";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pet;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(807, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.PMR);
            this.Controls.Add(this.AMR);
            this.Controls.Add(this.comboBoxMins);
            this.Controls.Add(this.comboBoxHour);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AnimalTypeCBO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GivenNameInput);
            this.Controls.Add(this.LastnameInput);
            this.Controls.Add(this.petsNameinput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox petsNameinput;
        private System.Windows.Forms.TextBox LastnameInput;
        private System.Windows.Forms.TextBox GivenNameInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RDrB;
        private System.Windows.Forms.RadioButton RDrC;
        private System.Windows.Forms.RadioButton RDrT;
        private System.Windows.Forms.RadioButton rCheckup;
        private System.Windows.Forms.RadioButton RDental;
        private System.Windows.Forms.RadioButton RHospital;
        private System.Windows.Forms.RadioButton RInnoculations;
        private System.Windows.Forms.RadioButton RSpay;
        private System.Windows.Forms.RadioButton RXray;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AnimalTypeCBO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.ComboBox comboBoxMins;
        private System.Windows.Forms.RadioButton AMR;
        private System.Windows.Forms.RadioButton PMR;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

