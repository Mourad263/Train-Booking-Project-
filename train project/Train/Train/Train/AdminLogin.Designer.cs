namespace Train
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            SignUpLb = new Label();
            BackLb = new Label();
            label1 = new Label();
            AdminIdTB = new TextBox();
            LoginBtn = new Button();
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            PasswordTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // SignUpLb
            // 
            SignUpLb.AutoSize = true;
            SignUpLb.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            SignUpLb.Location = new Point(21, 361);
            SignUpLb.Name = "SignUpLb";
            SignUpLb.Size = new Size(70, 21);
            SignUpLb.TabIndex = 65;
            SignUpLb.Text = "Sign Up";
            SignUpLb.Click += SignUpLb_Click;
            // 
            // BackLb
            // 
            BackLb.AutoSize = true;
            BackLb.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            BackLb.Location = new Point(256, 359);
            BackLb.Name = "BackLb";
            BackLb.Size = new Size(47, 21);
            BackLb.TabIndex = 64;
            BackLb.Text = "Back";
            BackLb.Click += BackLb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 115);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 63;
            label1.Text = "Admin Id";
            // 
            // AdminIdTB
            // 
            AdminIdTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdminIdTB.Location = new Point(68, 148);
            AdminIdTB.Name = "AdminIdTB";
            AdminIdTB.Size = new Size(200, 26);
            AdminIdTB.TabIndex = 62;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.SeaGreen;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Location = new Point(93, 286);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(153, 34);
            LoginBtn.TabIndex = 61;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(51, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 3);
            panel1.TabIndex = 58;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(51, 21);
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
            label4.Location = new Point(104, 21);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 56;
            label4.Text = "Train Booking";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(68, 197);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 67;
            label5.Text = "Password";
            // 
            // PasswordTB
            // 
            PasswordTB.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.Location = new Point(68, 230);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(200, 26);
            PasswordTB.TabIndex = 66;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 234, 211);
            ClientSize = new Size(339, 391);
            Controls.Add(label5);
            Controls.Add(PasswordTB);
            Controls.Add(SignUpLb);
            Controls.Add(BackLb);
            Controls.Add(label1);
            Controls.Add(AdminIdTB);
            Controls.Add(LoginBtn);
            Controls.Add(panel1);
            Controls.Add(pictureBox8);
            Controls.Add(label4);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignUpLb;
        private Label BackLb;
        private Label label1;
        private TextBox AdminIdTB;
        private Button LoginBtn;
        private Panel panel1;
        private PictureBox pictureBox8;
        private Label label4;
        private Label label5;
        private TextBox PasswordTB;
    }
}