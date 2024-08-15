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
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
            ApplyRoundedCorners(SignUpBtn, 30);
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // button click event to register user
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (FirstNameTB.Text == "" || LastNameTB.Text == "" || EmailTB.Text == "" || PasswordTB.Text == "" || AddressTB.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[User] (FirstName, LastName, Email, Password1, Address, Age,RegistrationDate) VALUES (@FirstName, @LastName, @Email, @Password, @Address,@Age, @RegDate);", connection);
                command.Parameters.AddWithValue("@FirstName", FirstNameTB.Text);
                command.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                command.Parameters.AddWithValue("@Email", EmailTB.Text);
                command.Parameters.AddWithValue("@Password", PasswordTB.Text);
                command.Parameters.AddWithValue("@Address", AddressTB.Text);
                command.Parameters.AddWithValue("@Age", AgeNumUD.Value);
                command.Parameters.AddWithValue("@RegDate", DateTime.Now);
                command.ExecuteNonQuery();
                MessageBox.Show("Registrated Successfully");
                connection.Close();

                UserLogin userLogin = new UserLogin();
                userLogin.Show();
                this.Close();
            }
        }

        // button click event to go back to login user page
        private void BackLb_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
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
