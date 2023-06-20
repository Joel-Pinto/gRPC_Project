using ClientNew.Models;

namespace ClientNew.Views
{
    /*Delegate Criation*/
    public delegate Task LoadTheaters(string host);
   // public delegate SendTheater.SendTheaterClient StartComm(string host);
    
    public partial class AddHostView : Form
    {
        //public event StartComm StartComm;
        public AddHostView()
        {
            InitializeComponent();
        }

        private void btnSubmitHost_Click(object sender, EventArgs e)
        {
            Program.ViewLogin.Show();
        }
    }
}