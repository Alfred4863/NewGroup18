namespace NewGroup18_ARS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            exitBtn = new Button();
            backBtn = new Button();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            airlineID = new TextBox();
            panel1 = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            crafts = new TextBox();
            airlineName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            tableNameHeader = new Label();
            panel3 = new Panel();
            label111 = new Label();
            saveButton = new Button();
            deletePanel = new Panel();
            msgBox = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            deletePanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            exitBtn.Location = new Point(899, 0);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(128, 96);
            exitBtn.TabIndex = 37;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(458, 273);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(163, 13);
            label8.TabIndex = 87;
            label8.Text = "*Enter numeric value only*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(458, 211);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(157, 13);
            label7.TabIndex = 86;
            label7.Text = "*String of max length 50*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("UD Digi Kyokasho N-R", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(458, 138);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 13);
            label10.TabIndex = 85;
            label10.Text = "*String should have exact length 8*";
            // 
            // airlineID
            // 
            airlineID.Location = new Point(459, 116);
            airlineID.Margin = new Padding(2);
            airlineID.Name = "airlineID";
            airlineID.Size = new Size(228, 23);
            airlineID.TabIndex = 80;
            airlineID.Click += airlineID_Click;
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
            panel1.Size = new Size(156, 638);
            panel1.TabIndex = 64;
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
            // crafts
            // 
            crafts.Location = new Point(459, 251);
            crafts.Margin = new Padding(2);
            crafts.Name = "crafts";
            crafts.Size = new Size(228, 23);
            crafts.TabIndex = 79;
            // 
            // airlineName
            // 
            airlineName.Location = new Point(460, 188);
            airlineName.Margin = new Padding(2);
            airlineName.Name = "airlineName";
            airlineName.Size = new Size(226, 23);
            airlineName.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(247, 250);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 76;
            label4.Text = "Airplanes";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(247, 188);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 22);
            label5.TabIndex = 77;
            label5.Text = "Airline Name";
            // 
            // tableNameHeader
            // 
            tableNameHeader.AutoSize = true;
            tableNameHeader.Font = new Font("UD Digi Kyokasho NP-R", 21F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tableNameHeader.ForeColor = Color.Black;
            tableNameHeader.Location = new Point(381, 112);
            tableNameHeader.Name = "tableNameHeader";
            tableNameHeader.Size = new Size(463, 33);
            tableNameHeader.TabIndex = 66;
            tableNameHeader.Text = "Addition of New Airline Company";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Location = new Point(157, 150);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 6);
            panel3.TabIndex = 67;
            // 
            // label111
            // 
            label111.AutoSize = true;
            label111.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label111.ForeColor = Color.Black;
            label111.Location = new Point(247, 116);
            label111.Margin = new Padding(2, 0, 2, 0);
            label111.Name = "label111";
            label111.Size = new Size(96, 22);
            label111.TabIndex = 74;
            label111.Text = "Airline ID";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 12F);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(433, 328);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(81, 37);
            saveButton.TabIndex = 55;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.SkyBlue;
            deletePanel.Controls.Add(msgBox);
            deletePanel.Controls.Add(label8);
            deletePanel.Controls.Add(label7);
            deletePanel.Controls.Add(label10);
            deletePanel.Controls.Add(airlineID);
            deletePanel.Controls.Add(crafts);
            deletePanel.Controls.Add(airlineName);
            deletePanel.Controls.Add(label5);
            deletePanel.Controls.Add(label4);
            deletePanel.Controls.Add(label111);
            deletePanel.Controls.Add(saveButton);
            deletePanel.Location = new Point(149, 156);
            deletePanel.Margin = new Padding(2);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(1034, 474);
            deletePanel.TabIndex = 69;
            // 
            // msgBox
            // 
            msgBox.AutoSize = true;
            msgBox.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            msgBox.ForeColor = Color.Black;
            msgBox.Location = new Point(334, 385);
            msgBox.Margin = new Padding(2, 0, 2, 0);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(287, 22);
            msgBox.TabIndex = 88;
            msgBox.Text = "\"Your Data has been saved;)\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-R", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(321, 56);
            label2.Name = "label2";
            label2.Size = new Size(302, 25);
            label2.TabIndex = 28;
            label2.Text = "Presented by NewGroup18";
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
            panel2.TabIndex = 65;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Khaki;
            ClientSize = new Size(1185, 638);
            Controls.Add(panel1);
            Controls.Add(tableNameHeader);
            Controls.Add(panel3);
            Controls.Add(deletePanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Enter += saveButton_Click;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox airlineID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox crafts;
        private System.Windows.Forms.TextBox airlineName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label msgBox;
    }
}