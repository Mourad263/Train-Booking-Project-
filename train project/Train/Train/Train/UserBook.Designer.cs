namespace Train
{
    partial class UserBook
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBook));
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            BookBtn = new Button();
            pictureBox7 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            CancelBtn = new Label();
            panel8 = new Panel();
            CurrentPageLB = new Panel();
            BookTicketBtn = new Label();
            pictureBox3 = new PictureBox();
            ShowSeatsBtn = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            LogoutLB = new Label();
            pictureBox13 = new PictureBox();
            label1 = new Label();
            UpdateBtn = new Label();
            pictureBox14 = new PictureBox();
            TripsDGV = new DataGridView();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            ClassCB = new ComboBox();
            PaymentCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CurrentPageLB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TripsDGV).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(598, 25);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 39;
            label4.Text = "Booking";
            // 
            // BookBtn
            // 
            BookBtn.BackColor = Color.SeaGreen;
            BookBtn.FlatStyle = FlatStyle.Flat;
            BookBtn.Location = new Point(578, 530);
            BookBtn.Name = "BookBtn";
            BookBtn.Size = new Size(153, 34);
            BookBtn.TabIndex = 50;
            BookBtn.Text = "Book";
            BookBtn.UseVisualStyleBackColor = false;
            BookBtn.Click += BookBtn_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(521, 18);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(71, 48);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(CancelBtn);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(CurrentPageLB);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(ShowSeatsBtn);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(LogoutLB);
            panel2.Controls.Add(pictureBox13);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(pictureBox14);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 710);
            panel2.TabIndex = 51;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 321);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            CancelBtn.AutoSize = true;
            CancelBtn.Location = new Point(104, 330);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(61, 21);
            CancelBtn.TabIndex = 37;
            CancelBtn.Text = "Cancel";
            CancelBtn.Click += CancelBtn_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(217, 234, 211);
            panel8.Location = new Point(91, 251);
            panel8.Name = "panel8";
            panel8.Size = new Size(31, 48);
            panel8.TabIndex = 36;
            // 
            // CurrentPageLB
            // 
            CurrentPageLB.BackColor = Color.FromArgb(217, 234, 211);
            CurrentPageLB.Controls.Add(BookTicketBtn);
            CurrentPageLB.Location = new Point(91, 251);
            CurrentPageLB.Name = "CurrentPageLB";
            CurrentPageLB.Size = new Size(144, 49);
            CurrentPageLB.TabIndex = 35;
            // 
            // BookTicketBtn
            // 
            BookTicketBtn.AutoSize = true;
            BookTicketBtn.Location = new Point(33, 13);
            BookTicketBtn.Name = "BookTicketBtn";
            BookTicketBtn.Size = new Size(50, 21);
            BookTicketBtn.TabIndex = 29;
            BookTicketBtn.Text = "Book";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 43);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 8;
            label1.Text = "Train Booking";
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
            // TripsDGV
            // 
            TripsDGV.AllowUserToAddRows = false;
            TripsDGV.AllowUserToDeleteRows = false;
            TripsDGV.AllowUserToOrderColumns = true;
            TripsDGV.BackgroundColor = Color.FromArgb(217, 234, 211);
            TripsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TripsDGV.Location = new Point(310, 121);
            TripsDGV.Name = "TripsDGV";
            TripsDGV.ReadOnly = true;
            TripsDGV.RowTemplate.Height = 25;
            TripsDGV.Size = new Size(637, 231);
            TripsDGV.TabIndex = 52;
            TripsDGV.CellContentClick += TripsDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 97);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 53;
            label2.Text = "Trips";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 396);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 55;
            label7.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(718, 396);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 57;
            label3.Text = "Payment";
            // 
            // ClassCB
            // 
            ClassCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassCB.FormattingEnabled = true;
            ClassCB.Items.AddRange(new object[] { "Economy", "First Class", "Business" });
            ClassCB.Location = new Point(471, 420);
            ClassCB.Name = "ClassCB";
            ClassCB.Size = new Size(121, 29);
            ClassCB.TabIndex = 58;
            // 
            // PaymentCB
            // 
            PaymentCB.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentCB.FormattingEnabled = true;
            PaymentCB.Items.AddRange(new object[] { "Cash", "Visa" });
            PaymentCB.Location = new Point(718, 420);
            PaymentCB.Name = "PaymentCB";
            PaymentCB.Size = new Size(121, 29);
            PaymentCB.TabIndex = 59;
            // 
            // UserBook
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 234, 211);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(984, 661);
            Controls.Add(PaymentCB);
            Controls.Add(ClassCB);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(TripsDGV);
            Controls.Add(panel2);
            Controls.Add(pictureBox7);
            Controls.Add(BookBtn);
            Controls.Add(label4);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "UserBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Ticket";
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CurrentPageLB.ResumeLayout(false);
            CurrentPageLB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)TripsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private Button BookBtn;
        private PictureBox pictureBox7;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label ShowSeatsBtn;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label LogoutLB;
        private PictureBox pictureBox13;
        private Label label1;
        private Label UpdateBtn;
        private PictureBox pictureBox14;
        private Panel panel8;
        private Panel CurrentPageLB;
        private Label BookTicketBtn;
        private DataGridView TripsDGV;
        private Label label2;
        private PictureBox pictureBox1;
        private Label CancelBtn;
        private Label label7;
        private Label label3;
        private ComboBox ClassCB;
        private ComboBox PaymentCB;
    }
}