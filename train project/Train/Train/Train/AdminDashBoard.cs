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
    public partial class AdminDashBoard : Form
    {
        string AdminId;
        public AdminDashBoard(string AdminId)
        {
            InitializeComponent();
            ApplyRoundedCorners(CurrentPageLB, 50);
            ApplyRoundedCorners(ReportPanel, 30);
            ApplyRoundedCorners(Report1Panel, 15);
            ApplyRoundedCorners(Report2Panel, 15);
            ApplyRoundedCorners(Report3Panel, 15);
            ApplyRoundedCorners(Report4Panel, 15);
            countTrain();
            countTrips();
            countUsers();
            countBookings();
            this.AdminId = AdminId;
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // this for count train report
        private void countTrain()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Train];", connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                TrainsLB.Text = reader[0].ToString();
            }
            connection.Close();
        }

        // this for count trips report
        private void countTrips()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Trip];", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                TripsLB.Text = reader[0].ToString();
            }
            connection.Close();
        }

        // this for count users report
        private void countUsers()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[User];", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                UsersLB.Text = reader[0].ToString();
            }
            connection.Close();
        }

        // this for count bookings report
        private void countBookings()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[Ticket];", connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                BookingsLB.Text = reader[0].ToString();
            }
            connection.Close();
        }

        // label click events to navigate to other forms (AddTrain)
        private void AddTrainLB_Click(object sender, EventArgs e)
        {
            AdminTrains adminAddTrain = new AdminTrains(AdminId);
            adminAddTrain.Show();
            this.Close();
        }


        // label click events to navigate to other forms (AddTrip)
        private void AddTripLB_Click(object sender, EventArgs e)
        {
            AdminTrips adminAddTrip = new AdminTrips(AdminId);
            adminAddTrip.Show();
            this.Close();
        }

        // label click events to navigate to other forms (Log out)
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        // this is for the rounded corners
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
    }
}
