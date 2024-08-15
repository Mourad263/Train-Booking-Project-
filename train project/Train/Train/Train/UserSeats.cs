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
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Train
{
    public partial class userseats : Form
    {
        string UserID;

        public userseats(string userID)
        {
            InitializeComponent();
            ApplyRoundedCorners(CurrentPageLB, 50);
            UserID = userID;
            ShowSeats();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");

        // function to show seats in datagridview
        private void ShowSeats()
        {
            connection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT  [dbo].[Train].Trainname, [dbo].[Trip].[Trip-no], [dbo].[Trip].[Available-seats] FROM [dbo].[Trip] INNER JOIN [dbo].[Train] ON [dbo].[Trip].[Train-id] = [dbo].[Train].[Train-id] ", connection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ListSeatsDGV.DataSource = dataSet.Tables[0];

            connection.Close();
        }

        // button click event to go to user update page
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UserUpdate userUpdate = new UserUpdate(UserID);
            userUpdate.Show();
            this.Close();
        }

        // button click event to go to user book ticket page
        private void BookTicketBtn_Click(object sender, EventArgs e)
        {
            UserBook userBooking = new UserBook(UserID);
            userBooking.Show();
            this.Close();
        }

        // button click event to logout user
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        // button click event to go to user cancel ticket page
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserCancel userCancel = new UserCancel(UserID);
            userCancel.Show();
            this.Close();
        }

        //functio to make rounded corners of panel
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
