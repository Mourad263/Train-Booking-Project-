namespace Train
{
    public partial class userPage : Form
    {
        string UserId;
        public userPage(string userId)
        {
            InitializeComponent();
            this.UserId = userId;
        }

        // button event click to logout and go to login user page
        private void LogoutLB_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        // button event click to go to user update page
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UserUpdate userUpdate = new UserUpdate(UserId);
            userUpdate.Show();
            this.Close();
        }

        // button event click to go to available seats page
        private void ShowSeatsBtn_Click(object sender, EventArgs e)
        {
            userseats userseats = new userseats(UserId);
            userseats.Show();
            this.Close();
        }

        // button event click to go to user booking ticket page
        private void BookTicketBtn_Click(object sender, EventArgs e)
        {
            UserBook userBooking = new UserBook(UserId);
            userBooking.Show();
            this.Close();
        }

        // button event click to go to user cancel ticket page
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserCancel userCancel = new UserCancel(UserId);
            userCancel.Show();
            this.Close();
        }
    }
}