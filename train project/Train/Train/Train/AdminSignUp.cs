using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
            ApplyRoundedCorners(SignUpBtn, 30);
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // button click event to register the admin
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (FirstNameTB.Text == "" || LastNameTB.Text == "" || EmailTB.Text == "" || PasswordTB.Text == "" || AddressTB.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                connection.Open();

                SqlCommand command = new SqlCommand("" +
                    "INSERT INTO [dbo].[Admin] (FirstName, LastName, Email, Password1, Address, Age, RegistrationDate) " +
                    "VALUES (@FirstName, @LastName, @Email, @Password, @Address, @Age, @RegDate); " +
                    "SELECT SCOPE_IDENTITY();", connection); 
                     // SCOPE_IDENTITY() returns the last inserted id

                command.Parameters.AddWithValue("@FirstName", FirstNameTB.Text);
                command.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                command.Parameters.AddWithValue("@Email", EmailTB.Text);
                command.Parameters.AddWithValue("@Password", PasswordTB.Text);
                command.Parameters.AddWithValue("@Address", AddressTB.Text);
                command.Parameters.AddWithValue("@Age", AgeNumUD.Value);
                command.Parameters.AddWithValue("@RegDate", DateTime.Now);

                int adminId = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show("Registered Successfully. \nAdmin ID: " + adminId);

                connection.Close();

                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                this.Close();
            }

        }

        // label click event to go back to the login page admin
        private void BackLb_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        // this method is used to make the button rounded
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
