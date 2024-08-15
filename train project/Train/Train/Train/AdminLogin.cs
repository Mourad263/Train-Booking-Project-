using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Train
{
    public partial class AdminLogin : Form
    {
        string AdminId;
        public AdminLogin()
        {
            InitializeComponent();
            ApplyRoundedCorners(LoginBtn, 30);
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // label click event to (go back) open the login page for user
        private void BackLb_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        // label click event to open the signup page
        private void SignUpLb_Click(object sender, EventArgs e)
        {
            AdminSignUp adminSignUp = new AdminSignUp();
            adminSignUp.Show();
            this.Close();
        }

        // button click event to login the admin
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (AdminIdTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                connection.Open();

                SqlCommand command = new SqlCommand("" +
                    "SELECT * FROM [dbo].[Admin] " +
                    "WHERE AdminId = @AdminId AND Password1 = @Password;", connection);

                command.Parameters.AddWithValue("@AdminId", AdminIdTB.Text);
                command.Parameters.AddWithValue("@Password", PasswordTB.Text);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    AdminId = reader["AdminId"].ToString();
                    AdminDashBoard adminPage = new AdminDashBoard(AdminId);
                    adminPage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid AdminId or Password");
                }

            }
        }

        // this function is used to make the button rounded
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
