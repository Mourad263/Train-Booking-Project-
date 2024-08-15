namespace Train
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            pictureBox8 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            EmailTB = new TextBox();
            LoginBtn = new Button();
            label1 = new Label();
            PasswordTB = new TextBox();
            AdminLB = new Label();
            SignUpLb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(51, 21);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 20;
            pictureBox8.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(104, 21);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 19;
            label4.Text = "Train Booking";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(51, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 3);
            panel1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(68, 115);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 44;
            label8.Text = "Email";
            // 
            // EmailTB
            // 
            EmailTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.Location = new Point(68, 148);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(200, 26);
            EmailTB.TabIndex = 43;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.SeaGreen;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Location = new Point(93, 286);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(153, 34);
            LoginBtn.TabIndex = 51;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 197);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 53;
            label1.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(68, 230);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(200, 26);
            PasswordTB.TabIndex = 52;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // AdminLB
            // 
            AdminLB.AutoSize = true;
            AdminLB.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            AdminLB.Location = new Point(250, 361);
            AdminLB.Name = "AdminLB";
            AdminLB.Size = new Size(62, 21);
            AdminLB.TabIndex = 54;
            AdminLB.Text = "Admin";
            AdminLB.Click += AdminLB_Click;
            // 
            // SignUpLb
            // 
            SignUpLb.AutoSize = true;
            SignUpLb.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            SignUpLb.Location = new Point(21, 361);
            SignUpLb.Name = "SignUpLb";
            SignUpLb.Size = new Size(70, 21);
            SignUpLb.TabIndex = 55;
            SignUpLb.Text = "Sign Up";
            SignUpLb.Click += SignUpLb_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 234, 211);
            ClientSize = new Size(339, 391);
            Controls.Add(SignUpLb);
            Controls.Add(AdminLB);
            Controls.Add(label1);
            Controls.Add(PasswordTB);
            Controls.Add(LoginBtn);
            Controls.Add(label8);
            Controls.Add(EmailTB);
            Controls.Add(panel1);
            Controls.Add(pictureBox8);
            Controls.Add(label4);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox8;
        private Label label4;
        private Panel panel1;
        private Label label8;
        private TextBox EmailTB;
        private Button LoginBtn;
        private Label label1;
        private TextBox PasswordTB;
        private Label AdminLB;
        private Label SignUpLb;
    }
}