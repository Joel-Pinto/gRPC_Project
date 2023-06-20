using Grpc.Core;
namespace ClientNew
{
    public partial class MainPage : Form
    {

        public delegate Task GetTheaters(string theater);
        public delegate Task<List<int>> LoadShow(string theater);
        public delegate Task SessionByShow(int idShow);
        public delegate Task LoadTickets();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void lstDiscover_SelectedIndexChanged(object sender, EventArgs e)
        {

            string theaterID = lstDiscover.SelectedItem.ToString().Split(' ')[0];

            //This code bellow needs to be changed

            GetTheaters getTheaters = new GetTheaters(Program.ControllerTheater.GetTheaterInfo);
            getTheaters.Invoke(theaterID);


            LoadShow loadShow = new LoadShow(Program.ControllerShow.LoadShow);
            List<int> idShowsArray = await loadShow.Invoke(theaterID);
            
            foreach(int idShows in idShowsArray)
            {
                SessionByShow loadSession = new SessionByShow(Program.ControllerSession.SessionByShow);
                loadSession.Invoke(idShows);
            }

            Program.UpdateWallet updateWallet = new Program.UpdateWallet(Program.ControllerWallet.UpDateWallet);
            double walletFunds = await updateWallet.Invoke();

            Program.ViewTheaterDetails.inWalletTxtBox.Text = walletFunds.ToString();

            Program.ViewTheaterDetails.ShowDialog();
        }

        private void btnBoughtTickets_Click(object sender, EventArgs e)
        {
            LoadTickets loadTickets = new LoadTickets(Program.ControllerTicket.LoadTickets);
            loadTickets.Invoke();

            Program.ViewBoughtTicket.Show();
        }
    }
}