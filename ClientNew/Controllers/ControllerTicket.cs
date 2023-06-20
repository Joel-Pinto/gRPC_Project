using Grpc.Net.Client;
using ClientNew.Models;
using Tulpep.NotificationWindow;
using Grpc.Core;

namespace ClientNew.Controllers
{
    class ControllerTicket
    {
        private SendTicket.SendTicketClient ticketClient { get; set; }


        public async Task BuyTicket(int ID_Session, int numbTickets)
        {
            LocalHost localHost = new LocalHost();

            var channel = GrpcChannel.ForAddress(localHost.Address);
            //Storing my connection ID
            ticketClient = new SendTicket.SendTicketClient(channel);

            var call = ticketClient.BuyTicket(new BuyTicketRequest
            { 
                IDSession = ID_Session,
                NumberOfTickets = numbTickets,
                UserID = Program.ControllerUser.UserID
            });

            if(call.Success)
            {
                var popUp = new PopupNotifier();

                popUp.TitleText = "Sucesso!";
                popUp.ContentText = "O bilhete foi comprado com sucesso!";
                popUp.IsRightToLeft = false;
                popUp.Popup();
            }
            else
            {
                var popUp = new PopupNotifier();

                popUp.TitleText = "Erro!";
                popUp.ContentText = "Fundos insuficientes para comprar o bilhete!";
                popUp.IsRightToLeft = false;
                popUp.Popup();
            }
        }

        public async Task LoadTickets()
        {
            int IDUser = Program.ControllerUser.UserID;

            LocalHost localHost = new LocalHost();

            var channel = GrpcChannel.ForAddress(localHost.Address);
            //Storing my connection ID
            ticketClient = new SendTicket.SendTicketClient(channel);

            var call = ticketClient.LoadTickets(new LoadTicketsRequest { UserID = IDUser });

            while (await call.ResponseStream.MoveNext())
            {
                var currentTicket = call.ResponseStream.Current;

                Program.ViewBoughtTicket.lstBoxBoughtTickets.Items.Add(
                    "Espetaculo: " + currentTicket.ShowName + "Dia: " + currentTicket.Date + "Hora: "
                    + currentTicket.Hour + "Numero de Bilhetes: " + currentTicket.NumbOfTickets + "Pago?: "
                    + currentTicket.IsItPaid);
            }
        }
    }
}