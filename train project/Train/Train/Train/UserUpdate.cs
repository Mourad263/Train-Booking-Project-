using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Train
{
    public partial class UserUpdate : Form
    {
        public UserUpdate(string UserId)
        {
            InitializeComponent();
            ApplyRoundedCorners(CurrentPageLB, 50);
            ApplyRoundedCorners(UpdateBtn2, 30);
            this.UserID = UserId;
            ShowUserDetails();
        }

        string UserID;
        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // function to show user details in textboxes
        private void ShowUserDetails()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[User] where [Userid]=@UserID;", connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                FirstNameTB.Text = reader["Firstname"].ToString();
                LastNameTB.Text = reader["Lastname"].ToString();
                EmailTB.Text = reader["Email"].ToString();
                PasswordTB.Text = reader["Password1"].ToString();
            }

            connection.Close();
        }
       
        // label click events to navigate to Available seats page
        private void ShowSeatsBtn_Click(object sender, EventArgs e)
        {
            userseats userseats = new userseats(UserID);
            userseats.Show();
            this.Close();
        }

        // label click events to navigate to booking page
        private void BookTicketBtn_Click(object sender, EventArgs e)
        {
            UserBook userBooking = new UserBook(UserID);
            userBooking.Show();
            this.Close();
        }

        // label click events to navigate to cancel page
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserCancel userCancel = new UserCancel(UserID);
            userCancel.Show();
            this.Close();
        }

        // label click events to logout user
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        // button click event to update user details
        private void UpdateBtn2_Click(object sender, EventArgs e)
        {
            if (FirstNameTB.Text == "" || LastNameTB.Text == "" || EmailTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update [dbo].[User] set [Firstname]=@FirstName, [Lastname]=@LastName, [Email]=@Email, [Password1]=@Password where [Userid] = @UserID", connection);

                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@FirstName", FirstNameTB.Text);
                    command.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                    command.Parameters.AddWithValue("@Email", EmailTB.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTB.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datat Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error Updating Data");
                    }
                    connection.Close();
                    ShowUserDetails();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // function to apply rounded corners to panel
        private void ApplyRoundedCorners(Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = panel.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

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
