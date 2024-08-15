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
using System.Data.SqlClient;

namespace Train
{
    public partial class UserCancel : Form
    {
        string TicketId, TripId;
        string UserID;
        int key = 0;
        public UserCancel(string UserId)
        {
            InitializeComponent();
            ApplyRoundedCorners(CurrentPageLB, 50);
            ApplyRoundedCorners(CancelBt, 30);
            this.UserID = UserId;
            ShowTickets();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // function to display tickets in the datagridview
        private void ShowTickets()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("" +
                "SELECT  [dbo].[Ticket].[TicketId], [dbo].[Ticket].[Class], [dbo].Payment.PaymentMethod,  [dbo].Trip.[Trip-no], [dbo].Trip.[Departure-station], [dbo].Trip.[Arrival-station], [dbo].Trip.Budget " +
                "FROM [dbo].[Ticket] " +
                "INNER JOIN [dbo].Payment " +
                "ON [dbo].[Ticket].PaymentID = [dbo].Payment.PaymentId " +
                "INNER JOIN [dbo].Trip ON [dbo].[Ticket].TripID = [dbo].Trip.[Trip-no] " +
                "where [dbo].[Ticket].UserID =@UserId ", connection);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@UserId", UserID);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            TicketsDGV.DataSource = dataSet.Tables[0];


            connection.Close();
        }

        // label event click to navigate to update page

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UserUpdate userUpdate = new UserUpdate(UserID);
            userUpdate.Show();
            this.Close();
        }

        // label event click to navigate to available seats page
        private void ShowSeatsBtn_Click(object sender, EventArgs e)
        {
            userseats userseats = new userseats(UserID);
            userseats.Show();
            this.Close();
        }

        // label event click to navigate to book ticket page
        private void BookTicketBtn_Click(object sender, EventArgs e)
        {
            UserBook userBook = new UserBook(UserID);
            userBook.Show();
            this.Close();
        }

        // label event click to navigate to cancel ticket page
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        // button event click to cancel ticket

        private void CancelBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Please Select a Ticket");
                }
                else
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("" +
                        "DELETE FROM [dbo].[Ticket] " +
                        "WHERE TicketId = @TicketId", connection);
                    
                    command.Parameters.AddWithValue("@TicketId", TicketId);
                    command.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    SqlCommand command2 = new SqlCommand("" +
                        "UPDATE [dbo].[Trip] SET [Available-seats] = [Available-seats] + 1 " +
                        "WHERE [Trip-no] = @TripId", connection);

                    command2.Parameters.AddWithValue("@TripId", TripId);
                    command2.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Ticket Canceled Successfully");
                    ShowTickets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // datagridview event click to select ticket
        private void TicketsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = TicketsDGV.Rows[rowIndex];
            TicketsDGV.Rows[rowIndex].Selected = true;

            TicketId = row.Cells[0].Value.ToString();
            TripId = row.Cells[3].Value.ToString();

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
