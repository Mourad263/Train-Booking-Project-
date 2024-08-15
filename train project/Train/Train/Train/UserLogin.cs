using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Train
{
    public partial class UserLogin : Form
    {
        string UserId;
        public UserLogin()
        {
            InitializeComponent();
            ApplyRoundedCorners(LoginBtn, 30);
        }

        // button click event to login user
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (EmailTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[User] WHERE Email = @Email AND Password1 = @Password;", connection);
                command.Parameters.AddWithValue("@Email", EmailTB.Text);
                command.Parameters.AddWithValue("@Password", PasswordTB.Text);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    EmailTB.Text = "";
                    PasswordTB.Text = "";
                    UserId = reader["UserId"].ToString();
                    userPage userPage = new userPage(UserId);
                    userPage.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }

                connection.Close();
            }
        }

        // button click event to go to admin login page
        private void AdminLB_Click(object sender, EventArgs e)
        {
            EmailTB.Text = "";
            PasswordTB.Text = "";
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            //this.Hide();
        }

        // button click event to go to user sign up page
        private void SignUpLb_Click(object sender, EventArgs e)
        {
            EmailTB.Text = "";
            PasswordTB.Text = "";
            UserSignUp userSignUp = new UserSignUp();
            userSignUp.Show();
            //this.Hide();
        }

        // function to apply rounded corners to button
        private void ApplyRoundedCorners(Button button, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = button.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();
            button.Region = new Region(path);
        }
    }
}
