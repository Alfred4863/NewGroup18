
namespace NewGroup18_ARS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            exitBtn = new Button();
            label1 = new Label();
            passBox = new TextBox();
            namBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
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
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(565, 1);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(129, 121);
            exitBtn.TabIndex = 46;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-R", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(122, 145);
            label1.Name = "label1";
            label1.Size = new Size(407, 34);
            label1.TabIndex = 51;
            label1.Text = "Airline Reservation System";
            // 
            // passBox
            // 
            passBox.Location = new Point(282, 329);
            passBox.Margin = new Padding(2, 2, 2, 2);
            passBox.Name = "passBox";
            passBox.Size = new Size(220, 23);
            passBox.TabIndex = 52;
            // 
            // namBox
            // 
            namBox.Location = new Point(282, 260);
            namBox.Margin = new Padding(2, 2, 2, 2);
            namBox.Name = "namBox";
            namBox.Size = new Size(220, 23);
            namBox.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NP-R", 14F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(164, 260);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 54;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NP-R", 14F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(164, 331);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 55;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(282, 391);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 56;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += logBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho NP-R", 14F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(278, 469);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(206, 22);
            label5.TabIndex = 58;
            label5.Text = "Create New Account!";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(282, 500);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(85, 34);
            button2.TabIndex = 59;
            button2.Text = "Signup";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(694, 574);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(namBox);
            Controls.Add(passBox);
            Controls.Add(exitBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox namBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}