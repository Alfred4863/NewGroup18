namespace NewGroup18_ARS
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            toCity = new ComboBox();
            airplaneIDBox = new ComboBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            backBtn = new Button();
            panel1 = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            exitBtn = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            msgBox = new Label();
            label4 = new Label();
            tableNameHeader = new Label();
            panel3 = new Panel();
            deletePanel = new Panel();
            AM = new TextBox();
            AH = new TextBox();
            DM = new TextBox();
            DH = new TextBox();
            dateA = new DateTimePicker();
            label14 = new Label();
            label17 = new Label();
            dateD = new DateTimePicker();
            label1 = new Label();
            h = new Label();
            label19 = new Label();
            label8 = new Label();
            fromCity = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            label10 = new Label();
            flightID = new TextBox();
            label111 = new Label();
            saveButton = new Button();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            deletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // toCity
            // 
            toCity.FormattingEnabled = true;
            toCity.Items.AddRange(new object[] { "Scheduled", "Chartered" });
            toCity.Location = new Point(191, 273);
            toCity.Margin = new Padding(2);
            toCity.Name = "toCity";
            toCity.Size = new Size(225, 23);
            toCity.TabIndex = 96;
            // 
            // airplaneIDBox
            // 
            airplaneIDBox.FormattingEnabled = true;
            airplaneIDBox.Items.AddRange(new object[] { "AirlineID" });
            airplaneIDBox.Location = new Point(193, 154);
            airplaneIDBox.Margin = new Padding(2);
            airplaneIDBox.Name = "airplaneIDBox";
            airplaneIDBox.Size = new Size(225, 23);
            airplaneIDBox.TabIndex = 95;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(188, 296);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(169, 13);
            label9.TabIndex = 93;
            label9.Text = "*Select from above options*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(46, 271);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(34, 22);
            label11.TabIndex = 90;
            label11.Text = "To";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(47, 155);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(115, 22);
            label12.TabIndex = 89;
            label12.Text = "Airplane ID";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.ForestGreen;
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Center;
            backBtn.Cursor = Cursors.Hand;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(0, 0);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(156, 156);
            backBtn.TabIndex = 36;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(backBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 637);
            panel1.TabIndex = 76;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LimeGreen;
            panel7.Controls.Add(label6);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(0, 154);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(156, 165);
            panel7.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("UD Digi Kyokasho NP-R", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(17, 116);
            label6.Name = "label6";
            label6.Size = new Size(93, 18);
            label6.TabIndex = 30;
            label6.Text = "Dashboard";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitBtn.BackColor = Color.Transparent;
            exitBtn.BackgroundImage = (Image)resources.GetObject("exitBtn.BackgroundImage");
            exitBtn.Cursor = Cursors.Hand;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.Red;
            exitBtn.Location = new Point(900, 0);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(127, 96);
            exitBtn.TabIndex = 37;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(exitBtn);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(157, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 96);
            panel2.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-R", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(351, 59);
            label2.Name = "label2";
            label2.Size = new Size(302, 25);
            label2.TabIndex = 28;
            label2.Text = "Presented by NewGroup18";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-R", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(291, 10);
            label3.Name = "label3";
            label3.Size = new Size(407, 34);
            label3.TabIndex = 1;
            label3.Text = "Airline Reservation System";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(191, 177);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 13);
            label7.TabIndex = 97;
            label7.Text = "*Select from above options*";
            // 
            // msgBox
            // 
            msgBox.AutoSize = true;
            msgBox.Font = new Font("Microsoft Sans Serif", 12F);
            msgBox.ForeColor = Color.White;
            msgBox.Location = new Point(334, 438);
            msgBox.Margin = new Padding(2, 0, 2, 0);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(0, 20);
            msgBox.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(46, 211);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 76;
            label4.Text = "From";
            // 
            // tableNameHeader
            // 
            tableNameHeader.AutoSize = true;
            tableNameHeader.Font = new Font("UD Digi Kyokasho NP-R", 21F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tableNameHeader.ForeColor = Color.Black;
            tableNameHeader.Location = new Point(483, 111);
            tableNameHeader.Name = "tableNameHeader";
            tableNameHeader.Size = new Size(321, 33);
            tableNameHeader.TabIndex = 78;
            tableNameHeader.Text = "Addition of New Flight";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Location = new Point(157, 150);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 6);
            panel3.TabIndex = 79;
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.SkyBlue;
            deletePanel.Controls.Add(AM);
            deletePanel.Controls.Add(AH);
            deletePanel.Controls.Add(DM);
            deletePanel.Controls.Add(DH);
            deletePanel.Controls.Add(dateA);
            deletePanel.Controls.Add(label14);
            deletePanel.Controls.Add(label17);
            deletePanel.Controls.Add(dateD);
            deletePanel.Controls.Add(label1);
            deletePanel.Controls.Add(h);
            deletePanel.Controls.Add(label19);
            deletePanel.Controls.Add(label8);
            deletePanel.Controls.Add(fromCity);
            deletePanel.Controls.Add(label15);
            deletePanel.Controls.Add(label16);
            deletePanel.Controls.Add(label18);
            deletePanel.Controls.Add(label7);
            deletePanel.Controls.Add(toCity);
            deletePanel.Controls.Add(airplaneIDBox);
            deletePanel.Controls.Add(label9);
            deletePanel.Controls.Add(label11);
            deletePanel.Controls.Add(label12);
            deletePanel.Controls.Add(msgBox);
            deletePanel.Controls.Add(label10);
            deletePanel.Controls.Add(flightID);
            deletePanel.Controls.Add(label4);
            deletePanel.Controls.Add(label111);
            deletePanel.Controls.Add(saveButton);
            deletePanel.Location = new Point(149, 156);
            deletePanel.Margin = new Padding(2);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(1034, 474);
            deletePanel.TabIndex = 81;
            // 
            // AM
            // 
            AM.Location = new Point(806, 151);
            AM.Margin = new Padding(2);
            AM.Name = "AM";
            AM.Size = new Size(44, 23);
            AM.TabIndex = 127;
            // 
            // AH
            // 
            AH.Location = new Point(705, 150);
            AH.Margin = new Padding(2);
            AH.Name = "AH";
            AH.Size = new Size(44, 23);
            AH.TabIndex = 126;
            // 
            // DM
            // 
            DM.Location = new Point(806, 92);
            DM.Margin = new Padding(2);
            DM.Name = "DM";
            DM.Size = new Size(44, 23);
            DM.TabIndex = 125;
            // 
            // DH
            // 
            DH.Location = new Point(705, 91);
            DH.Margin = new Padding(2);
            DH.Name = "DH";
            DH.Size = new Size(44, 23);
            DH.TabIndex = 124;
            // 
            // dateA
            // 
            dateA.CustomFormat = "dd-MM-yyyy";
            dateA.Format = DateTimePickerFormat.Custom;
            dateA.Location = new Point(705, 275);
            dateA.Margin = new Padding(2);
            dateA.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateA.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateA.Name = "dateA";
            dateA.Size = new Size(114, 23);
            dateA.TabIndex = 123;
            dateA.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(540, 272);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(122, 22);
            label14.TabIndex = 122;
            label14.Text = "Arrival Date";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(540, 211);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(156, 22);
            label17.TabIndex = 121;
            label17.Text = "Departure Date";
            // 
            // dateD
            // 
            dateD.CustomFormat = "dd-MM-yyyy";
            dateD.Format = DateTimePickerFormat.Custom;
            dateD.Location = new Point(705, 215);
            dateD.Margin = new Padding(2);
            dateD.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dateD.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateD.Name = "dateD";
            dateD.Size = new Size(114, 23);
            dateD.TabIndex = 118;
            dateD.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(810, 177);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 13);
            label1.TabIndex = 117;
            label1.Text = "Min";
            // 
            // h
            // 
            h.AutoSize = true;
            h.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            h.ForeColor = Color.Black;
            h.Location = new Point(715, 175);
            h.Margin = new Padding(2, 0, 2, 0);
            h.Name = "h";
            h.Size = new Size(19, 13);
            h.TabIndex = 114;
            h.Text = "HH";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("UD Digi Kyokasho NP-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(810, 114);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(26, 13);
            label19.TabIndex = 113;
            label19.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(187, 237);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(169, 13);
            label8.TabIndex = 109;
            label8.Text = "*Select from above options*";
            // 
            // fromCity
            // 
            fromCity.FormattingEnabled = true;
            fromCity.Items.AddRange(new object[] { "AirlineID" });
            fromCity.Location = new Point(189, 214);
            fromCity.Margin = new Padding(2);
            fromCity.Name = "fromCity";
            fromCity.Size = new Size(225, 23);
            fromCity.TabIndex = 108;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(715, 115);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(19, 13);
            label15.TabIndex = 105;
            label15.Text = "HH";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("UD Digi Kyokasho NP-R", 14F);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(540, 151);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(121, 22);
            label16.TabIndex = 101;
            label16.Text = "Arrival Time";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(540, 91);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(155, 22);
            label18.TabIndex = 99;
            label18.Text = "Departure Time";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(188, 115);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 13);
            label10.TabIndex = 85;
            label10.Text = "*String should have exact length 8*";
            // 
            // flightID
            // 
            flightID.Location = new Point(189, 93);
            flightID.Margin = new Padding(2);
            flightID.Name = "flightID";
            flightID.Size = new Size(228, 23);
            flightID.TabIndex = 80;
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label111.ForeColor = Color.Black;
            label111.Location = new Point(46, 91);
            label111.Margin = new Padding(2, 0, 2, 0);
            label111.Name = "label111";
            label111.Size = new Size(91, 22);
            label111.TabIndex = 74;
            label111.Text = "Flight ID";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 12F);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(436, 382);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(81, 37);
            saveButton.TabIndex = 55;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Khaki;
            ClientSize = new Size(1190, 637);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(tableNameHeader);
            Controls.Add(panel3);
            Controls.Add(deletePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox toCity;
        private System.Windows.Forms.ComboBox airplaneIDBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox flightID;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fromCity;
        private System.Windows.Forms.DateTimePicker dateA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox AM;
        private System.Windows.Forms.TextBox AH;
        private System.Windows.Forms.TextBox DM;
        private System.Windows.Forms.TextBox DH;
    }
}