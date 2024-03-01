namespace NewGroup18_ARS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            deletePanel = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            country = new TextBox();
            airportID = new TextBox();
            city = new TextBox();
            airportName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            deletePromptLabel = new Label();
            deleteButtonCon = new Button();
            panel3 = new Panel();
            label2 = new Label();
            exitBtn = new Button();
            label3 = new Label();
            panel2 = new Panel();
            backBtn = new Button();
            panel1 = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            tableNameHeader = new Label();
            deletePanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.SkyBlue;
            deletePanel.Controls.Add(label9);
            deletePanel.Controls.Add(label8);
            deletePanel.Controls.Add(label7);
            deletePanel.Controls.Add(label10);
            deletePanel.Controls.Add(country);
            deletePanel.Controls.Add(airportID);
            deletePanel.Controls.Add(city);
            deletePanel.Controls.Add(airportName);
            deletePanel.Controls.Add(label5);
            deletePanel.Controls.Add(label4);
            deletePanel.Controls.Add(label1);
            deletePanel.Controls.Add(deletePromptLabel);
            deletePanel.Controls.Add(deleteButtonCon);
            deletePanel.Location = new Point(152, 156);
            deletePanel.Margin = new Padding(2, 2, 2, 2);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(1031, 474);
            deletePanel.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(467, 286);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 13);
            label9.TabIndex = 88;
            label9.Text = "*String of length 20*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(467, 228);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(133, 13);
            label8.TabIndex = 87;
            label8.Text = "*String of length 20*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(467, 166);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(157, 13);
            label7.TabIndex = 86;
            label7.Text = "*String of max length 70*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(467, 93);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 13);
            label10.TabIndex = 85;
            label10.Text = "*String should have exact length 8*";
            // 
            // country
            // 
            country.Location = new Point(470, 265);
            country.Margin = new Padding(2, 2, 2, 2);
            country.Name = "country";
            country.Size = new Size(226, 23);
            country.TabIndex = 81;
            // 
            // airportID
            // 
            airportID.Location = new Point(468, 71);
            airportID.Margin = new Padding(2, 2, 2, 2);
            airportID.Name = "airportID";
            airportID.Size = new Size(228, 23);
            airportID.TabIndex = 80;
            // 
            // city
            // 
            city.Location = new Point(468, 206);
            city.Margin = new Padding(2, 2, 2, 2);
            city.Name = "city";
            city.Size = new Size(228, 23);
            city.TabIndex = 79;
            // 
            // airportName
            // 
            airportName.Location = new Point(470, 143);
            airportName.Margin = new Padding(2, 2, 2, 2);
            airportName.Name = "airportName";
            airportName.Size = new Size(226, 23);
            airportName.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(257, 143);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 22);
            label5.TabIndex = 77;
            label5.Text = "Airport Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(257, 205);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 22);
            label4.TabIndex = 76;
            label4.Text = "City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(257, 265);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 22);
            label1.TabIndex = 75;
            label1.Text = "Country";
            // 
            // deletePromptLabel
            // 
            deletePromptLabel.AutoSize = true;
            deletePromptLabel.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            deletePromptLabel.ForeColor = Color.Black;
            deletePromptLabel.Location = new Point(257, 68);
            deletePromptLabel.Margin = new Padding(2, 0, 2, 0);
            deletePromptLabel.Name = "deletePromptLabel";
            deletePromptLabel.Size = new Size(103, 22);
            deletePromptLabel.TabIndex = 74;
            deletePromptLabel.Text = "Airport ID";
            // 
            // deleteButtonCon
            // 
            deleteButtonCon.Font = new Font("Microsoft Sans Serif", 12F);
            deleteButtonCon.ForeColor = Color.Black;
            deleteButtonCon.Location = new Point(433, 346);
            deleteButtonCon.Margin = new Padding(2, 2, 2, 2);
            deleteButtonCon.Name = "deleteButtonCon";
            deleteButtonCon.Size = new Size(81, 37);
            deleteButtonCon.TabIndex = 55;
            deleteButtonCon.Text = "Add";
            deleteButtonCon.UseVisualStyleBackColor = true;
            deleteButtonCon.Click += deleteButtonCon_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Location = new Point(156, 150);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 6);
            panel3.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-R", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(320, 58);
            label2.Name = "label2";
            label2.Size = new Size(302, 25);
            label2.TabIndex = 28;
            label2.Text = "Presented by NewGroup18";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-R", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(261, 9);
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
            panel2.Location = new Point(156, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 96);
            panel2.TabIndex = 56;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Center;
            backBtn.Cursor = Cursors.Hand;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(0, 0);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(156, 96);
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
            panel1.Size = new Size(156, 631);
            panel1.TabIndex = 55;
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
            // tableNameHeader
            // 
            tableNameHeader.AutoSize = true;
            tableNameHeader.Font = new Font("UD Digi Kyokasho NP-R", 21F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tableNameHeader.ForeColor = Color.Black;
            tableNameHeader.Location = new Point(430, 109);
            tableNameHeader.Name = "tableNameHeader";
            tableNameHeader.Size = new Size(338, 33);
            tableNameHeader.TabIndex = 57;
            tableNameHeader.Text = "Addition of New Airport";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Khaki;
            ClientSize = new Size(1185, 631);
            Controls.Add(deletePanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tableNameHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button deleteButtonCon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox airportID;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox airportName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deletePromptLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}