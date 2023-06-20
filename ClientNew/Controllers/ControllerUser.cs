using Grpc.Net.Client;
using ClientNew.Models;
using Tulpep.NotificationWindow;
using Grpc.Core;


namespace ClientNew.Controllers
{
    class ControllerUser
    {
        public delegate Task LoadTheaters();

        private SendUser.SendUserClient userClient { get; set; }
        
        public int UserID { get; set; }

        public async Task VerifyUser(string _user)
        {
            LocalHost localHost = new LocalHost();

            var channel = GrpcChannel.ForAddress(localHost.Address);
            //Storing my connection ID
            userClient = new SendUser.SendUserClient(channel);

            var call = await userClient.VerifyUserAsync(new UserVerifyRequest { 
                
                Username = _user
            
            });

            if(call.DoesExist)
            {
                //Storing the user name to latter access it when needed
                UserID = call.UserID;

                LoadTheaters loadTheaters = new LoadTheaters(Program.ControllerTheater.LoadTheater);
                loadTheaters.Invoke();

                Program.UpdateWallet updateWallet = new Program.UpdateWallet(Program.ControllerWallet.UpDateWallet);
                double walletFunds = await updateWallet.Invoke();

                Program.ViewMainPage.inWalletTxtBox.Text = walletFunds.ToString();

                Program.ViewMainPage.Show();
            }
            else
            {
                var popUp = new PopupNotifier();

                popUp.TitleText = "WARNING";
                popUp.ContentText = "This username does not exist!";
                popUp.IsRightToLeft = false;
                popUp.Popup();
            }
        }

        public async Task InsertUser(string _name, string _username, string _location, int _age)
        {
            LocalHost localHost = new LocalHost();

            var channel = GrpcChannel.ForAddress(localHost.Address);

            userClient = new SendUser.SendUserClient(channel);

            //All user that register by themselves are by default normal users
            var call = userClient.InsertUser(new InsertUserRequest()
            {
                Name = _name,
                Location = _location,
                UserName = _username,
                Age = _age,
                Role = 1
            });

            if (call.IsInserted)
            {
                var popUp = new PopupNotifier();

                popUp.TitleText = "Success";
                popUp.ContentText = "You have been registered with success!";
                popUp.IsRightToLeft = false;
                popUp.Popup();

                Program.ViewLogin.Show();
            }
            else
            {
                var popUp = new PopupNotifier();

                popUp.TitleText = "WARNING";
                popUp.ContentText = "This username already exist!";
                popUp.IsRightToLeft = false;
                popUp.Popup();
            }
        }
    }
}