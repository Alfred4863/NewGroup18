namespace NewGroup18_ARS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel3 = new Panel();
            exitBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            backBtn = new Button();
            panel1 = new Panel();
            panel10 = new Panel();
            flightButton = new Label();
            panel4 = new Panel();
            airplaneButton = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            tableNameHeader = new Label();
            viewGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameCol = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CAR_ID = new DataGridViewTextBoxColumn();
            arrival = new DataGridViewTextBoxColumn();
            departure = new DataGridViewTextBoxColumn();
            panel8 = new Panel();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            panel6 = new Panel();
            pictureBox7 = new PictureBox();
            deleteButton = new Label();
            panel9 = new Panel();
            pictureBox8 = new PictureBox();
            label9 = new Label();
            deletePanel = new Panel();
            selectAttribute = new ComboBox();
            newValueBox = new TextBox();
            label1 = new Label();
            deleteButtonCon = new Button();
            deletePromptLabel = new Label();
            deleteIDTextBox = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewGrid).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            deletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Location = new Point(156, 150);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1027, 6);
            panel3.TabIndex = 46;
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
            exitBtn.Location = new Point(898, 0);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(129, 96);
            exitBtn.TabIndex = 37;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-R", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.FromArgb(77, 74, 82);
            label2.Location = new Point(415, 64);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 28;
            label2.Text = "Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-R", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.FromArgb(77, 74, 82);
            label3.Location = new Point(277, 14);
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
            panel2.TabIndex = 44;
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(backBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 663);
            panel1.TabIndex = 43;
            // 
            // panel10
            // 
            panel10.BackColor = Color.PaleGreen;
            panel10.Controls.Add(flightButton);
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(0, 404);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(156, 86);
            panel10.TabIndex = 42;
            // 
            // flightButton
            // 
            flightButton.AutoSize = true;
            flightButton.BackColor = Color.Transparent;
            flightButton.FlatStyle = FlatStyle.Flat;
            flightButton.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            flightButton.ForeColor = Color.Black;
            flightButton.Location = new Point(31, 56);
            flightButton.Name = "flightButton";
            flightButton.Size = new Size(73, 22);
            flightButton.TabIndex = 30;
            flightButton.Text = "Flights";
            flightButton.TextAlign = ContentAlignment.MiddleCenter;
            flightButton.Click += flightButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(airplaneButton);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(0, 316);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(156, 86);
            panel4.TabIndex = 41;
            // 
            // airplaneButton
            // 
            airplaneButton.AutoSize = true;
            airplaneButton.BackColor = Color.Transparent;
            airplaneButton.FlatStyle = FlatStyle.Flat;
            airplaneButton.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            airplaneButton.ForeColor = Color.Black;
            airplaneButton.Location = new Point(31, 56);
            airplaneButton.Name = "airplaneButton";
            airplaneButton.Size = new Size(97, 22);
            airplaneButton.TabIndex = 30;
            airplaneButton.Text = "Airplanes";
            airplaneButton.TextAlign = ContentAlignment.MiddleCenter;
            airplaneButton.Click += airplaneButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.PaleGreen;
            panel5.Controls.Add(label5);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(0, 236);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(156, 82);
            panel5.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 55);
            label5.Name = "label5";
            label5.Size = new Size(68, 22);
            label5.TabIndex = 30;
            label5.Text = "Airline";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LimeGreen;
            panel7.Controls.Add(label6);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(0, 154);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(156, 86);
            panel7.TabIndex = 39;
            panel7.Paint += panel7_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(36, 51);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 30;
            label6.Text = "Airport";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // tableNameHeader
            // 
            tableNameHeader.AutoSize = true;
            tableNameHeader.Font = new Font("UD Digi Kyokasho NP-R", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tableNameHeader.ForeColor = Color.Black;
            tableNameHeader.Location = new Point(433, 100);
            tableNameHeader.Name = "tableNameHeader";
            tableNameHeader.Size = new Size(368, 31);
            tableNameHeader.TabIndex = 45;
            tableNameHeader.Text = "Presented by NewGroup18";
            // 
            // viewGrid
            // 
            viewGrid.AllowUserToAddRows = false;
            viewGrid.AllowUserToDeleteRows = false;
            viewGrid.AllowUserToResizeColumns = false;
            viewGrid.AllowUserToResizeRows = false;
            viewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewGrid.BackgroundColor = Color.Ivory;
            viewGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            viewGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 41, 54);
            dataGridViewCellStyle1.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 41, 54);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewGrid.Columns.AddRange(new DataGridViewColumn[] { ID, NameCol, City, Country, Status, CAR_ID, arrival, departure });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            viewGrid.DefaultCellStyle = dataGridViewCellStyle2;
            viewGrid.EnableHeadersVisualStyles = false;
            viewGrid.GridColor = Color.MistyRose;
            viewGrid.Location = new Point(156, 204);
            viewGrid.Margin = new Padding(3, 4, 3, 4);
            viewGrid.Name = "viewGrid";
            viewGrid.ReadOnly = true;
            viewGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            viewGrid.RowHeadersVisible = false;
            viewGrid.RowHeadersWidth = 62;
            viewGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewGrid.Size = new Size(1027, 326);
            viewGrid.TabIndex = 42;
            viewGrid.CellContentClick += viewCarGrid_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Airport_ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NameCol
            // 
            NameCol.HeaderText = "Airport_Name";
            NameCol.MinimumWidth = 8;
            NameCol.Name = "NameCol";
            NameCol.ReadOnly = true;
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 8;
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 8;
            Country.Name = "Country";
            Country.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // CAR_ID
            // 
            CAR_ID.HeaderText = "ID";
            CAR_ID.MinimumWidth = 8;
            CAR_ID.Name = "CAR_ID";
            CAR_ID.ReadOnly = true;
            // 
            // arrival
            // 
            arrival.HeaderText = "Arrival";
            arrival.MinimumWidth = 8;
            arrival.Name = "arrival";
            arrival.ReadOnly = true;
            // 
            // departure
            // 
            departure.HeaderText = "Column1";
            departure.MinimumWidth = 8;
            departure.Name = "departure";
            departure.ReadOnly = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Coral;
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label7);
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(478, 534);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(114, 81);
            panel8.TabIndex = 50;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Center;
            pictureBox6.Enabled = false;
            pictureBox6.Location = new Point(21, 4);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(68, 44);
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(17, 52);
            label7.Name = "label7";
            label7.Size = new Size(59, 22);
            label7.TabIndex = 30;
            label7.Text = "  Add";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Coral;
            panel6.Controls.Add(pictureBox7);
            panel6.Controls.Add(deleteButton);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(702, 534);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(109, 81);
            panel6.TabIndex = 51;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Center;
            pictureBox7.Enabled = false;
            pictureBox7.Location = new Point(21, 4);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(68, 44);
            pictureBox7.TabIndex = 29;
            pictureBox7.TabStop = false;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = Color.Transparent;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(17, 52);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(70, 22);
            deleteButton.TabIndex = 30;
            deleteButton.Text = "Delete";
            deleteButton.TextAlign = ContentAlignment.MiddleCenter;
            deleteButton.Click += deleteButton_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Coral;
            panel9.Controls.Add(pictureBox8);
            panel9.Controls.Add(label9);
            panel9.Cursor = Cursors.Hand;
            panel9.Location = new Point(591, 534);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(114, 81);
            panel9.TabIndex = 51;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Center;
            pictureBox8.Enabled = false;
            pictureBox8.Location = new Point(21, 4);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(68, 44);
            pictureBox8.TabIndex = 29;
            pictureBox8.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("UD Digi Kyokasho NP-R", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(17, 52);
            label9.Name = "label9";
            label9.Size = new Size(65, 22);
            label9.TabIndex = 30;
            label9.Text = "   Edit";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.Coral;
            deletePanel.Controls.Add(selectAttribute);
            deletePanel.Controls.Add(newValueBox);
            deletePanel.Controls.Add(label1);
            deletePanel.Controls.Add(deleteButtonCon);
            deletePanel.Controls.Add(deletePromptLabel);
            deletePanel.Controls.Add(deleteIDTextBox);
            deletePanel.Location = new Point(157, 156);
            deletePanel.Margin = new Padding(2, 2, 2, 2);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(1025, 44);
            deletePanel.TabIndex = 53;
            // 
            // selectAttribute
            // 
            selectAttribute.FormattingEnabled = true;
            selectAttribute.Location = new Point(17, 14);
            selectAttribute.Margin = new Padding(2, 2, 2, 2);
            selectAttribute.Name = "selectAttribute";
            selectAttribute.Size = new Size(150, 23);
            selectAttribute.TabIndex = 58;
            // 
            // newValueBox
            // 
            newValueBox.Location = new Point(566, 10);
            newValueBox.Margin = new Padding(2, 2, 2, 2);
            newValueBox.Name = "newValueBox";
            newValueBox.Size = new Size(244, 23);
            newValueBox.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-R", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(440, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 18);
            label1.TabIndex = 56;
            label1.Text = "New Value";
            // 
            // deleteButtonCon
            // 
            deleteButtonCon.Font = new Font("Microsoft Sans Serif", 12F);
            deleteButtonCon.ForeColor = Color.Black;
            deleteButtonCon.Location = new Point(842, 5);
            deleteButtonCon.Margin = new Padding(2, 2, 2, 2);
            deleteButtonCon.Name = "deleteButtonCon";
            deleteButtonCon.Size = new Size(81, 37);
            deleteButtonCon.TabIndex = 55;
            deleteButtonCon.Text = "Delete";
            deleteButtonCon.UseVisualStyleBackColor = true;
            deleteButtonCon.Click += deleteButtonCon_Click;
            // 
            // deletePromptLabel
            // 
            deletePromptLabel.AutoSize = true;
            deletePromptLabel.Font = new Font("UD Digi Kyokasho NP-R", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            deletePromptLabel.ForeColor = Color.Black;
            deletePromptLabel.Location = new Point(180, 11);
            deletePromptLabel.Margin = new Padding(2, 0, 2, 0);
            deletePromptLabel.Name = "deletePromptLabel";
            deletePromptLabel.Size = new Size(26, 18);
            deletePromptLabel.TabIndex = 54;
            deletePromptLabel.Text = "ID";
            // 
            // deleteIDTextBox
            // 
            deleteIDTextBox.Location = new Point(216, 13);
            deleteIDTextBox.Margin = new Padding(2, 2, 2, 2);
            deleteIDTextBox.Name = "deleteIDTextBox";
            deleteIDTextBox.Size = new Size(202, 23);
            deleteIDTextBox.TabIndex = 54;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Khaki;
            ClientSize = new Size(1184, 663);
            Controls.Add(deletePanel);
            Controls.Add(panel6);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tableNameHeader);
            Controls.Add(viewGrid);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewGrid).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tableNameHeader;
        private System.Windows.Forms.DataGridView viewGrid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label airplaneButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label deleteButton;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label flightButton;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button deleteButtonCon;
        private System.Windows.Forms.Label deletePromptLabel;
        private System.Windows.Forms.TextBox deleteIDTextBox;
        private System.Windows.Forms.ComboBox selectAttribute;
        private System.Windows.Forms.TextBox newValueBox;
        private System.Windows.Forms.Label label1;
    }
}
