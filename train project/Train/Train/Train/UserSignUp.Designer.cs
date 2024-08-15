namespace Train
{
    partial class UserSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignUp));
            label1 = new Label();
            EmailTB = new TextBox();
            SignUpBtn = new Button();
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            label4 = new Label();
            label8 = new Label();
            LastNameTB = new TextBox();
            label7 = new Label();
            FirstNameTB = new TextBox();
            label5 = new Label();
            PasswordTB = new TextBox();
            label6 = new Label();
            AddressTB = new TextBox();
            BackLb = new Label();
            label2 = new Label();
            AgeNumUD = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgeNumUD).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 168);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 63;
            label1.Text = "Email";
            // 
            // EmailTB
            // 
            EmailTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.Location = new Point(27, 201);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(200, 26);
            EmailTB.TabIndex = 62;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.SeaGreen;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Location = new Point(93, 480);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(153, 34);
            SignUpBtn.TabIndex = 61;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(50, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 3);
            panel1.TabIndex = 58;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(50, 15);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 57;
            pictureBox8.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(103, 15);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 56;
            label4.Text = "Train Booking";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(185, 83);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 69;
            label8.Text = "Last Name";
            // 
            // LastNameTB
            // 
            LastNameTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTB.Location = new Point(185, 118);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(122, 26);
            LastNameTB.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 83);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 67;
            label7.Text = "First Name";
            // 
            // FirstNameTB
            // 
            FirstNameTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTB.Location = new Point(27, 116);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.Size = new Size(131, 26);
            FirstNameTB.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 247);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 71;
            label5.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(27, 280);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(200, 26);
            PasswordTB.TabIndex = 70;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 318);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 73;
            label6.Text = "Address";
            // 
            // AddressTB
            // 
            AddressTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddressTB.Location = new Point(27, 351);
            AddressTB.Name = "AddressTB";
            AddressTB.Size = new Size(200, 26);
            AddressTB.TabIndex = 72;
            // 
            // BackLb
            // 
            BackLb.AutoSize = true;
            BackLb.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            BackLb.Location = new Point(263, 526);
            BackLb.Name = "BackLb";
            BackLb.Size = new Size(47, 21);
            BackLb.TabIndex = 74;
            BackLb.Text = "Back";
            BackLb.Click += BackLb_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 395);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 76;
            label2.Text = "Age";
            // 
            // AgeNumUD
            // 
            AgeNumUD.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgeNumUD.Location = new Point(27, 433);
            AgeNumUD.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            AgeNumUD.Name = "AgeNumUD";
            AgeNumUD.Size = new Size(120, 26);
            AgeNumUD.TabIndex = 77;
            AgeNumUD.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // UserSignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 234, 211);
            ClientSize = new Size(343, 556);
            Controls.Add(AgeNumUD);
            Controls.Add(label2);
            Controls.Add(BackLb);
            Controls.Add(label6);
            Controls.Add(AddressTB);
            Controls.Add(label5);
            Controls.Add(PasswordTB);
            Controls.Add(label8);
            Controls.Add(LastNameTB);
            Controls.Add(label7);
            Controls.Add(FirstNameTB);
            Controls.Add(label1);
            Controls.Add(EmailTB);
            Controls.Add(SignUpBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox8);
            Controls.Add(label4);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgeNumUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox EmailTB;
        private Button SignUpBtn;
        private Panel panel1;
        private PictureBox pictureBox8;
        private Label label4;
        private Label label8;
        private TextBox LastNameTB;
        private Label label7;
        private TextBox FirstNameTB;
        private Label label5;
        private TextBox PasswordTB;
        private Label label6;
        private TextBox AddressTB;
        private Label BackLb;
        private Label label2;
        private NumericUpDown AgeNumUD;
    }
}