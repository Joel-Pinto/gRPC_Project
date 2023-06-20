using Grpc.Net.Client;
using ClientNew.Models;
using Tulpep.NotificationWindow;
using Grpc.Core;

namespace ClientNew.Controllers
{
    class ControllerWallet
    {
        private SendWalletInfo.SendWalletInfoClient walletClient { get; set; }


        public async Task<double> UpDateWallet()
        {
            LocalHost localHost = new LocalHost();

            var channel = GrpcChannel.ForAddress(localHost.Address);
            //Storing my connection ID
            walletClient = new SendWalletInfo.SendWalletInfoClient(channel);

            int userID = Program.ControllerUser.UserID;

            var call = await walletClient.UpDateWalletAsync(new UpdateRequest
            {
                UserId = userID
            });

            return call.WalletFunds;
        }

    }
}
