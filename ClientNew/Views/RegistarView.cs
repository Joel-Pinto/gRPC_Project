using Tulpep.NotificationWindow;


namespace ClientNew.Views
{
    public delegate Task AddUser(string _name, string _username, string _location, int _age);
    public partial class RegistarView : Form
    {
        public RegistarView()
        {
            InitializeComponent();
        }

        private async void btnRegistar_Click(object sender, EventArgs e)
        {
            string Name = txtBoxName.Text;
            string Username = txtBoxUsername.Text;
            string Location = txtBoxLocation.Text;
            var today = DateTime.Today;

            int Age = today.Year - dateBirthday.Value.Year;

            AddUser userAdd = new AddUser(Program.ControllerUser.InsertUser);
            await userAdd.Invoke(Name, Username, Location, Age);

            this.Close();
        }
    }
}