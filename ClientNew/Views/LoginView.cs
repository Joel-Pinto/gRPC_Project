namespace ClientNew.Views
{
    public partial class LoginView : Form
    {
        public delegate Task LoadTheaters();

        public delegate Task VerifyUser(string _user);

        public LoginView()
        {
            InitializeComponent();
        }

        private void lnkLbRegistar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.ViewRegistar.Show();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //In here we are going to call the VerifyUser function in the ControllerUser
            //And se if the user exists
            VerifyUser userVerification = new VerifyUser(Program.ControllerUser.VerifyUser);
            await userVerification.Invoke(userTxtB.Text);
        }
    }
}
