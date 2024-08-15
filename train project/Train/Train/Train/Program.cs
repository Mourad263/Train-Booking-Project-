using System.Data.SqlClient;

namespace Train
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            /*
            SqlConnection connection = new SqlConnection("Server=DESKTOP-TKTSUPV;Database=TrainBooking;Trusted_Connection=True;");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[User];", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                // Process the data retrieved from each row
                // Example: Retrieve the value of a column by column name
                string username = reader["FirstName"].ToString();
                MessageBox.Show(username);
            }

            connection.Close();
            */


            ApplicationConfiguration.Initialize();
            Application.Run(new UserLogin());
            
        }
    }
}