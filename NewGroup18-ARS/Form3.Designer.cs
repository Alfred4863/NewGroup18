namespace NewGroup18_ARS
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            msgBox = new Label();
            label2 = new Label();
            label8 = new Label();
            label10 = new Label();
            airplaneID = new TextBox();
            tableNameHeader = new Label();
            panel3 = new Panel();
            deletePanel = new Panel();
            label13 = new Label();
            label7 = new Label();
            category = new ComboBox();
            airlineIDBox = new ComboBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            seats = new TextBox();
            regNumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label111 = new Label();
            saveButton = new Button();
            label3 = new Label();
            panel2 = new Panel();
            exitBtn = new Button();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel7 = new Panel();
            panel1 = new Panel();
            backBtn = new Button();
            deletePanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // msgBox
            // 
            msgBox.AutoSize = true;
            msgBox.Font = new Font("Microsoft Sans Serif", 12F);
            msgBox.ForeColor = Color.White;
            msgBox.Location = new Point(334, 412);
            msgBox.Margin = new Padding(2, 0, 2, 0);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(0, 20);
            msgBox.TabIndex = 88;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(453, 200);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(217, 13);
            label8.TabIndex = 87;
            label8.Text = "*Enter numeric value of max 3 char*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(453, 77);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 13);
            label10.TabIndex = 85;
            label10.Text = "*String should have exact length 8*";
            // 
            // airplaneID
            // 
            airplaneID.Location = new Point(453, 55);
            airplaneID.Margin = new Padding(2);
            airplaneID.Name = "airplaneID";
            airplaneID.Size = new Size(228, 23);
            airplaneID.TabIndex = 80;
            airplaneID.TextChanged += airplaneID_TextChanged;
            // 
            // tableNameHeader
            // 
            tableNameHeader.AutoSize = true;
            tableNameHeader.Font = new Font("UD Digi Kyokasho NP-R", 21F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tableNameHeader.ForeColor = Color.Black;
            tableNameHeader.Location = new Point(483, 113);
            tableNameHeader.Name = "tableNameHeader";
            tableNameHeader.Size = new Size(357, 33);
            tableNameHeader.TabIndex = 72;
            tableNameHeader.Text = "Addition of New Airplane";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Location = new Point(157, 150);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 6);
            panel3.TabIndex = 73;
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.SkyBlue;
            deletePanel.Controls.Add(label13);
            deletePanel.Controls.Add(label7);
            deletePanel.Controls.Add(category);
            deletePanel.Controls.Add(airlineIDBox);
            deletePanel.Controls.Add(label9);
            deletePanel.Controls.Add(label11);
            deletePanel.Controls.Add(label12);
            deletePanel.Controls.Add(msgBox);
            deletePanel.Controls.Add(label8);
            deletePanel.Controls.Add(label10);
            deletePanel.Controls.Add(airplaneID);
            deletePanel.Controls.Add(seats);
            deletePanel.Controls.Add(regNumber);
            deletePanel.Controls.Add(label5);
            deletePanel.Controls.Add(label4);
            deletePanel.Controls.Add(label111);
            deletePanel.Controls.Add(saveButton);
            deletePanel.Location = new Point(149, 156);
            deletePanel.Margin = new Padding(2);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(1034, 474);
            deletePanel.TabIndex = 75;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(453, 138);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(217, 13);
            label13.TabIndex = 98;
            label13.Text = "*String should have exact length 8*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(453, 322);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 13);
            label7.TabIndex = 97;
            label7.Text = "*Select from above options*";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Scheduled", "Chartered" });
            category.Location = new Point(453, 240);
            category.Margin = new Padding(2);
            category.Name = "category";
            category.Size = new Size(225, 23);
            category.TabIndex = 96;
            // 
            // airlineIDBox
            // 
            airlineIDBox.FormattingEnabled = true;
            airlineIDBox.Items.AddRange(new object[] { "AirlineID" });
            airlineIDBox.Location = new Point(455, 299);
            airlineIDBox.Margin = new Padding(2);
            airlineIDBox.Name = "airlineIDBox";
            airlineIDBox.Size = new Size(225, 23);
            airlineIDBox.TabIndex = 95;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(451, 263);
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
            label11.Location = new Point(240, 241);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(96, 22);
            label11.TabIndex = 90;
            label11.Text = "Category";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(240, 302);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(96, 22);
            label12.TabIndex = 89;
            label12.Text = "Airline ID";
            // 
            // seats
            // 
            seats.Location = new Point(453, 178);
            seats.Margin = new Padding(2);
            seats.Name = "seats";
            seats.Size = new Size(228, 23);
            seats.TabIndex = 79;
            // 
            // regNumber
            // 
            regNumber.Location = new Point(455, 116);
            regNumber.Margin = new Padding(2);
            regNumber.Name = "regNumber";
            regNumber.Size = new Size(226, 23);
            regNumber.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(242, 116);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 22);
            label5.TabIndex = 77;
            label5.Text = "Reg Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(242, 176);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 76;
            label4.Text = "Seats";
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label111.ForeColor = Color.Black;
            label111.Location = new Point(242, 55);
            label111.Margin = new Padding(2, 0, 2, 0);
            label111.Name = "label111";
            label111.Size = new Size(115, 22);
            label111.TabIndex = 74;
            label111.Text = "Airplane ID";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 12F);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(432, 355);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(81, 37);
            saveButton.TabIndex = 55;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-R", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(287, 12);
            label3.Name = "label3";
            label3.Size = new Size(407, 34);
            label3.TabIndex = 1;
            label3.Text = "Airline Reservation System";
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
            panel2.TabIndex = 71;
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
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Enabled = false;
            pictureBox5.Location = new Point(30, 41);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(82, 45);
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("UD Digi Kyokasho NP-R", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 116);
            label6.Name = "label6";
            label6.Size = new Size(93, 18);
            label6.TabIndex = 30;
            label6.Text = "Dashboard";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LimeGreen;
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label6);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(0, 154);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(156, 165);
            panel7.TabIndex = 39;
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
            panel1.Size = new Size(156, 633);
            panel1.TabIndex = 70;
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Khaki;
            ClientSize = new Size(1187, 633);
            Controls.Add(tableNameHeader);
            Controls.Add(panel3);
            Controls.Add(deletePanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label msgBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox airplaneID;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.TextBox seats;
        private System.Windows.Forms.TextBox regNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox airlineIDBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox category;
    }
}