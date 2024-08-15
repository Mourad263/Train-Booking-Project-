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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Train
{
    public partial class AdminTrips : Form
    {
        string AdminId;
        int key = 0;
        public AdminTrips(string adminId)
        {
            InitializeComponent();
            ApplyRoundedCorners(CurrentPageLB, 50);
            ApplyRoundedCorners(AddBtn, 30);
            ApplyRoundedCorners(DeleteBtn, 30);
            ApplyRoundedCorners(UpdateBtn, 30);
            ShowTrips();
            AdminId = adminId;
            AdminNoTB.Text = adminId;
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // function to display the trips in the data grid view
        private void ShowTrips()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Trip]", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                TripsDGV.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // label click event to open the dashboard page
        private void DashBoardLB_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard(AdminId);
            adminDashBoard.Show();
            this.Close();
        }

        // label click event to open the trains page
        private void AddTrainLB_Click(object sender, EventArgs e)
        {
            AdminTrains adminAddTrain = new AdminTrains(AdminId);
            adminAddTrain.Show();
            this.Close();
        }

        // label click event to logout the admin
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        // button click event to add a new trip
        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (AdminNoTB.Text == "" || TripNoTB.Text == "" || TrainIdTB.Text == "" || ArrivalStationTB.Text == "" || DepartureStationTB.Text == "" || TripDurationTB.Text == "" || BudgetTB.Text == "" || AvailableSeatsTB.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }

            else
            {
                try
                {
                    // this to get the number of seats in the train 
                    connection.Open();
                    SqlCommand command = new SqlCommand("" +
                        "SELECT [Seat-no] FROM [dbo].[Train] " +
                        "where [Train-id] = @TrainId", connection);

                    command.Parameters.AddWithValue("@TrainId", TrainIdTB.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    int seats = 1000000000;
                    while (reader.Read())
                    {
                        seats = Convert.ToInt32(reader["Seat-no"]);
                    }
                    reader.Close();
                    connection.Close();

                    // compare number of seats with the available seats
                    if (Convert.ToInt32(AvailableSeatsTB.Text) > seats)
                    {
                        MessageBox.Show("The number of available seats is more than the number of seats in the train");
                        return;
                    }

                    connection.Open();
                    command = new SqlCommand("" +
                        "INSERT INTO [dbo].[Trip] ([Trip-no],[Admin-no],[Train-id],[trip-duration],[Arrival-station],[Departure-station], [Available-seats], [Budget]) " +
                        "VALUES (@TripNO, @AdminNO, @TrainId, @TripDuration, @ArrivalStation, @DepartureStation, @AvailableSeats, @Budget)", connection);

                    command.Parameters.AddWithValue("@TripNO", TripNoTB.Text);
                    command.Parameters.AddWithValue("@AdminNO", AdminNoTB.Text);
                    command.Parameters.AddWithValue("@TrainId", TrainIdTB.Text);
                    command.Parameters.AddWithValue("@TripDuration", TripDurationTB.Text);
                    command.Parameters.AddWithValue("@ArrivalStation", ArrivalStationTB.Text);
                    command.Parameters.AddWithValue("@DepartureStation", DepartureStationTB.Text);
                    command.Parameters.AddWithValue("@AvailableSeats", AvailableSeatsTB.Text);
                    command.Parameters.AddWithValue("@Budget", BudgetTB.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error Adding Trip");
                    }
                    connection.Close();
                    ShowTrips();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        // button click event to update an existing trip
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (AdminNoTB.Text == "" || TripNoTB.Text == "" || TrainIdTB.Text == "" || ArrivalStationTB.Text == "" || DepartureStationTB.Text == "" || TripDurationTB.Text == "" || BudgetTB.Text == "" || AvailableSeatsTB.Text == "")
            {
                MessageBox.Show("Please select the trip to update");
            }
            else
            {
                try
                {
                    // this to get the number of seats in the train 
                    connection.Open();
                    SqlCommand command = new SqlCommand("" +
                        "SELECT [Seat-no] FROM [dbo].[Train] " +
                        "where [Train-id] = @TrainId", connection);

                    command.Parameters.AddWithValue("@TrainId", TrainIdTB.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    int seats = 0;
                    while (reader.Read())
                    {
                        seats = Convert.ToInt32(reader["Seat-no"]);
                    }
                    reader.Close();
                    connection.Close();

                    // compare number of seats with the available seats
                    if (Convert.ToInt32(AvailableSeatsTB.Text) > seats)
                    {
                        MessageBox.Show("The number of available seats is more than the number of seats in the train");
                        return;
                    }

                    connection.Open();
                    command = new SqlCommand("" +
                        "Update [dbo].[Trip] set [Trip-no]=@TripNO, [Admin-no]=@AdminNO, [Train-id]=@TrainId, [trip-duration]=@TripDuration, [Arrival-station]=@ArrivalStation, [Departure-station]=@DepartureStation, [Available-seats]=@AvailableSeats,[Budget]=@Budget " +
                        "where [Tripp-no] = @TripNo", connection);

                    command.Parameters.AddWithValue("@TripNO", TripNoTB.Text);
                    command.Parameters.AddWithValue("@AdminNO", AdminNoTB.Text);
                    command.Parameters.AddWithValue("@TrainId", TrainIdTB.Text);
                    command.Parameters.AddWithValue("@TripDuration", TripDurationTB.Text);
                    command.Parameters.AddWithValue("@ArrivalStation", ArrivalStationTB.Text);
                    command.Parameters.AddWithValue("@DepartureStation", DepartureStationTB.Text);
                    command.Parameters.AddWithValue("@AvailableSeats", AvailableSeatsTB.Text);
                    command.Parameters.AddWithValue("@Budget", BudgetTB.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error Updating Trip");
                    }
                    connection.Close();
                    ShowTrips();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // button click event to delete an existing trip
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select the trip to delete");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("" +
                        "delete from [dbo].[Trip] " +
                        "where [Tripp-no] = @TripNO ", connection);

                    command.Parameters.AddWithValue("@TripNO", TrainIdTB.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error Deleting Trip");
                    }
                    connection.Close();
                    ShowTrips();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // data grid view click event to show the selected trip data in the text boxes
        private void TripsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = TripsDGV.Rows[rowIndex];
            TripsDGV.Rows[rowIndex].Selected = true;
            TripNoTB.Text = row.Cells[0].Value.ToString();
            //AdminNoTB.Text = row.Cells[1].Value.ToString();
            TrainIdTB.Text = row.Cells[2].Value.ToString();
            TripDurationTB.Text = row.Cells[3].Value.ToString();
            ArrivalStationTB.Text = row.Cells[4].Value.ToString();
            DepartureStationTB.Text = row.Cells[5].Value.ToString();
            AvailableSeatsTB.Text = row.Cells[6].Value.ToString();
            BudgetTB.Text = row.Cells[7].Value.ToString();

            if (TrainIdTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TripsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        // this function is used to make the panel rounded
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
