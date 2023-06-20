using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientNew.Views
{
    public partial class TheaterDetails : Form
    {
        public delegate Task BuyTicket(int ID_Session, int numbTickets);

        public TheaterDetails()
        {
            InitializeComponent();
        }

        private async void buyTicketBtn_Click(object sender, EventArgs e)
        {
            int i = lstBoxSessoes.SelectedIndex;

            int ID_Session = Program.ControllerSession.ListShows[i];

            int numbTickets = Convert.ToInt32(numberTickets.Value);

            BuyTicket loadShow = new BuyTicket(Program.ControllerTicket.BuyTicket);
            loadShow.Invoke(ID_Session, numbTickets);

            Program.UpdateWallet updateWallet = new Program.UpdateWallet(Program.ControllerWallet.UpDateWallet);
            double walletFunds = await updateWallet.Invoke();

            inWalletTxtBox.Text = walletFunds.ToString();
        }
    }
}
