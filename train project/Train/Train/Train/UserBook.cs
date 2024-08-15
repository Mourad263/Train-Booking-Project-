using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class UserBook : Form
    {
        string UserID;
        string TripId, GateWay, Amount;
        int key = 0;

        public UserBook(string userID)
        {
            InitializeComponent();
            ApplyRoundedCorners(CurrentPageLB, 50);
            ApplyRoundedCorners(BookBtn, 30);
            UserID = userID;
            ShowTrips();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // function to display trips in the datagridview
        private void ShowTrips()
        {
            connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT  [dbo].[Train].Trainname, [dbo].[Trip].[Trip-no], [dbo].[Trip].[Available-seats], [dbo].[Trip].[Arrival-station], [dbo].[Trip].[Departure-station], [dbo].[Trip].[trip-duration], [dbo].[Trip].Budget FROM [dbo].[Trip] INNER JOIN [dbo].[Train] ON [dbo].[Trip].[Train-id] = [dbo].[Train].[Train-id] where [dbo].[Trip].[Available-seats] > 0", connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            TripsDGV.DataSource = dataSet.Tables[0];

            connection.Close();
        }

        // button event click to navigate to the user profile page
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UserUpdate userUpdate = new UserUpdate(UserID);
            userUpdate.Show();
            this.Close();
        }

        // button event click to navigate to the available seats page
        private void ShowSeatsBtn_Click(object sender, EventArgs e)
        {
            userseats userseats = new userseats(UserID);
            userseats.Show();
            this.Close();
        }

        // button event click to navigate to the user cancel page
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserCancel userCancel = new UserCancel(UserID);
            userCancel.Show();
            this.Close();
        }

        // button event click to logout user
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        // button event click to book a ticket
        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a trip");
            }
            else if (ClassCB.Text == "")
            {
                MessageBox.Show("Please select a class");
            }
            else if (PaymentCB.Text == "")
            {
                MessageBox.Show("Please select a payment method");
            }
            else
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Payment] ([PaymentDate], [PaymentStatus], [PaymentGateway], [Amount], [VisaNumber], [PaymentMethod]) VALUES (@PaymentDate, @PaymentStatse, @PaymentGatway, @Amount, @VisaNumber, @PaymentMethod); SELECT SCOPE_IDENTITY();", connection);
                    command.Parameters.AddWithValue("@PaymentDate", DateTime.Now.ToString("MMMM d, yyyy HH:mm:ss"));
                    command.Parameters.AddWithValue("@PaymentStatse", "Paid");
                    command.Parameters.AddWithValue("@PaymentGatway", GateWay);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@VisaNumber", (0000).ToString());
                    command.Parameters.AddWithValue("@PaymentMethod", PaymentCB.Text);
                    int PaymentID = Convert.ToInt32(command.ExecuteScalar());

                    SqlCommand command2 = new SqlCommand("INSERT INTO [dbo].[Ticket] ([UserID], [TripID], [PaymentID], [Class]) VALUES (@UserId, @TripId, @PaymentId, @Class);", connection);
                    command2.Parameters.AddWithValue("@UserId", UserID);
                    command2.Parameters.AddWithValue("@TripId", TripId);
                    command2.Parameters.AddWithValue("@PaymentId", PaymentID);
                    command2.Parameters.AddWithValue("@Class", ClassCB.Text);
                    command2.ExecuteNonQuery();

                    SqlCommand command3 = new SqlCommand("UPDATE [dbo].[Trip] SET [Available-seats] = [Available-seats] - 1 WHERE [Trip-no] = @TripId", connection);
                    command3.Parameters.AddWithValue("@TripId", TripId);
                    command3.ExecuteNonQuery();

                    MessageBox.Show("Your ticket has been booked successfully");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // datagridview event click to select a trip
        private void TripsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = TripsDGV.Rows[rowIndex];
            TripsDGV.Rows[rowIndex].Selected = true;

            TripId = row.Cells[1].Value.ToString();
            GateWay = row.Cells[4].Value.ToString();
            Amount = row.Cells[6].Value.ToString();

            key = 1;
        }

        // function to apply rounded corners to the panel
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

        // function to apply rounded corners to the button
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
