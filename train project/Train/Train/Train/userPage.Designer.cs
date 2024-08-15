namespace Train
{
    partial class userPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPage));
            UpdateBtn = new Label();
            label4 = new Label();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            CancelBtn = new Label();
            pictureBox3 = new PictureBox();
            BookTicketBtn = new Label();
            ShowSeatsBtn = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            LogoutLB = new Label();
            pictureBox13 = new PictureBox();
            label8 = new Label();
            pictureBox14 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.AutoSize = true;
            UpdateBtn.Location = new Point(104, 139);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(67, 21);
            UpdateBtn.TabIndex = 0;
            UpdateBtn.Text = "Update";
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(522, 26);
            label4.Name = "label4";
            label4.Size = new Size(179, 32);
            label4.TabIndex = 13;
            label4.Text = "Train Booking";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(397, 335);
            label7.Name = "label7";
            label7.Size = new Size(471, 54);
            label7.TabIndex = 14;
            label7.Text = "Welcome To User Page";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(522, 223);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(179, 109);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(CancelBtn);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(BookTicketBtn);
            panel2.Controls.Add(ShowSeatsBtn);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(LogoutLB);
            panel2.Controls.Add(pictureBox13);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(pictureBox14);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 710);
            panel2.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            CancelBtn.AutoSize = true;
            CancelBtn.Location = new Point(108, 331);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(61, 21);
            CancelBtn.TabIndex = 39;
            CancelBtn.Text = "Cancel";
            CancelBtn.Click += CancelBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // BookTicketBtn
            // 
            BookTicketBtn.AutoSize = true;
            BookTicketBtn.Location = new Point(104, 264);
            BookTicketBtn.Name = "BookTicketBtn";
            BookTicketBtn.Size = new Size(50, 21);
            BookTicketBtn.TabIndex = 29;
            BookTicketBtn.Text = "Book";
            BookTicketBtn.Click += BookTicketBtn_Click;
            // 
            // ShowSeatsBtn
            // 
            ShowSeatsBtn.AutoSize = true;
            ShowSeatsBtn.Location = new Point(104, 204);
            ShowSeatsBtn.Name = "ShowSeatsBtn";
            ShowSeatsBtn.Size = new Size(99, 21);
            ShowSeatsBtn.TabIndex = 28;
            ShowSeatsBtn.Text = "Show Seats";
            ShowSeatsBtn.Click += ShowSeatsBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(47, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(45, 129);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // LogoutLB
            // 
            LogoutLB.AutoSize = true;
            LogoutLB.Location = new Point(104, 593);
            LogoutLB.Name = "LogoutLB";
            LogoutLB.Size = new Size(72, 21);
            LogoutLB.TabIndex = 13;
            LogoutLB.Text = "Log Out";
            LogoutLB.Click += LogoutLB_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(45, 579);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(36, 45);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 9;
            pictureBox13.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 43);
            label8.Name = "label8";
            label8.Size = new Size(120, 21);
            label8.TabIndex = 8;
            label8.Text = "Train Booking";
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(28, 23);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(78, 60);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 7;
            pictureBox14.TabStop = false;
            // 
            // userPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 234, 211);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(984, 661);
            Controls.Add(panel2);
            Controls.Add(pictureBox7);
            Controls.Add(label7);
            Controls.Add(label4);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "userPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label UpdateBtn;
        private Label label4;
        private Label label7;
        private PictureBox pictureBox7;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label BookTicketBtn;
        private Label ShowSeatsBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label LogoutLB;
        private PictureBox pictureBox13;
        private Label label8;
        private PictureBox pictureBox14;
        private PictureBox pictureBox1;
        private Label CancelBtn;
    }
}