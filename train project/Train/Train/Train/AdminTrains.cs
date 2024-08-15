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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Train
{
    public partial class AdminTrains : Form
    {
        string AdminId;
        int key = 0;
        public AdminTrains(string AdminId)
        {
            InitializeComponent();
            ApplyRoundedCorners(CurrentPageLB, 50);
            ApplyRoundedCorners(UpdateBtn, 30);
            ApplyRoundedCorners(AddBtn, 30);
            ApplyRoundedCorners(DeleteBtn, 30);
            ShowTrains();
            this.AdminId = AdminId;
            AdminIdTB.Text = AdminId;
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // function to display the trains in the datagridview
        private void ShowTrains()
        {
            connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [dbo].[Train]", connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            TrainsDGV.DataSource = dataSet.Tables[0];

            connection.Close();
        }

        // label click event to open the dashboard page
        private void DashBoardLB_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminPage = new AdminDashBoard(AdminId);
            adminPage.Show();
            this.Close();
        }

        // label click event to open the trains page
        private void AddTripLB_Click(object sender, EventArgs e)
        {
            AdminTrips addTripAdmin = new AdminTrips(AdminId);
            addTripAdmin.Show();
            this.Close();
        }

        // label click event to logout the admin
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        // button click event to add a new train
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TrainIdTB.Text == "" || TrainNameTB.Text == "" || SourceTB.Text == "" || DestinationTB.Text == "" || DistanceTB.Text == "" || SeatNumTB.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("" +
                        "INSERT INTO [dbo].[Train] (Trainname, Source, Destination, Distance, ArrivalTime, [Departure-Time],[Train-id],[Admin-no],[Seat-no]) " +
                        "VALUES (@TrainName, @Source, @Destination, @Distance, @ArrivalTime, @DepartureTime,@TrainId,@AdminNO, @SeatNum)", connection);

                    command.Parameters.AddWithValue("@TrainName", TrainNameTB.Text);
                    command.Parameters.AddWithValue("@Source", SourceTB.Text);
                    command.Parameters.AddWithValue("@Destination", DestinationTB.Text);
                    command.Parameters.AddWithValue("@Distance", DistanceTB.Text);
                    command.Parameters.AddWithValue("@ArrivalTime", ArrivalTimeD.Value);
                    command.Parameters.AddWithValue("@DepartureTime", DepartureTimeD.Value);
                    command.Parameters.AddWithValue("@TrainId", TrainIdTB.Text);
                    command.Parameters.AddWithValue("@AdminNO", AdminIdTB.Text);
                    command.Parameters.AddWithValue("@SeatNum", SeatNumTB.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Train Added Successfully");


                    }
                    else
                    {
                        MessageBox.Show("Error Adding Train");
                    }
                    connection.Close();
                    ShowTrains();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // button click event to update an existing train
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (TrainIdTB.Text == "" || TrainNameTB.Text == "" || SourceTB.Text == "" || DestinationTB.Text == "" || DistanceTB.Text == "" || SeatNumTB.Text == "")
            {
                MessageBox.Show("Please select the train to update");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("" +
                        "Update [dbo].[Train] set Trainname=@TrainName, Source=@Source, Destination=@Destination, Distance=@Distance, ArrivalTime=@ArrivalTime, [Departure-Time]=@DepartureTime, [Admin-no]=@AdminNO, [Seat-no]=@SeatNum " +
                        "where [Train-id] = @TrainID", connection);

                    command.Parameters.AddWithValue("@TrainName", TrainNameTB.Text);
                    command.Parameters.AddWithValue("@Source", SourceTB.Text);
                    command.Parameters.AddWithValue("@Destination", DestinationTB.Text);
                    command.Parameters.AddWithValue("@Distance", DistanceTB.Text);
                    command.Parameters.AddWithValue("@ArrivalTime", ArrivalTimeD.Value);
                    command.Parameters.AddWithValue("@DepartureTime", DepartureTimeD.Value);
                    command.Parameters.AddWithValue("@TrainId", TrainIdTB.Text);
                    command.Parameters.AddWithValue("@AdminNO", AdminIdTB.Text);
                    command.Parameters.AddWithValue("@SeatNum", SeatNumTB.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Train Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error Updating Train");
                    }
                    connection.Close();
                    ShowTrains();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // button click event to delete an existing train
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select the train to delete");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("" +
                        "delete from [dbo].[Train] " +
                        "where [Train-id] = @TrainId ", connection);

                    command.Parameters.AddWithValue("@TrainId", TrainIdTB.Text);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Train Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error Deleting Train");
                    }
                    connection.Close();
                    ShowTrains();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // datagridview click event to show the selected train details in the textboxes (to update or delete)
        private void TrainsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = TrainsDGV.Rows[rowIndex];
            TrainsDGV.Rows[rowIndex].Selected = true;
            TrainIdTB.Text = TrainsDGV.Rows[rowIndex].Cells[0].Value.ToString();
            TrainNameTB.Text = TrainsDGV.Rows[rowIndex].Cells[1].Value.ToString();
            SourceTB.Text = TrainsDGV.Rows[rowIndex].Cells[2].Value.ToString();
            DestinationTB.Text = TrainsDGV.Rows[rowIndex].Cells[3].Value.ToString();
            DistanceTB.Text = TrainsDGV.Rows[rowIndex].Cells[4].Value.ToString();
            ArrivalTimeD.Text = TrainsDGV.Rows[rowIndex].Cells[5].Value.ToString();
            DepartureTimeD.Text = TrainsDGV.Rows[rowIndex].Cells[6].Value.ToString();
            //AdminIdTB.Text = TrainsDGV.Rows[rowIndex].Cells[7].Value.ToString();
            SeatNumTB.Text = TrainsDGV.Rows[rowIndex].Cells[8].Value.ToString();

            if (TrainIdTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TrainsDGV.SelectedRows[0].Cells[0].Value.ToString());
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
