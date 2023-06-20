using Grpc.Net.Client;
using ClientNew.Models;
using Grpc.Core;

namespace ClientNew.Controllers
{
    class ControllerTheater
    {
        private SendTheater.SendTheaterClient theaterClient { get; set; }
        //public LocalHost Host { get; set; }

        public ControllerTheater()
        {
            //Tenho que incializar aqui a comunicacao, desta forma as funcoes podem ser executadas enumeras vezes
        }

        public async Task LoadTheater()
        {
            //Host.Address = host;
            LocalHost localHost = new LocalHost();

            var channel = GrpcChannel.ForAddress(localHost.Address);
            //Storing my connection ID
            theaterClient = new SendTheater.SendTheaterClient(channel);

            var call = theaterClient.LoadTheater(new TheaterLoadRequest());

            while (await call.ResponseStream.MoveNext())
            {
                var currentTheater = call.ResponseStream.Current;

                Program.ViewMainPage.lstDiscover.Items.Add(currentTheater.ID + "    " + currentTheater.TheaterName + "   " + currentTheater.Location + "   " + currentTheater.Address);
            }
        }

        public async Task GetTheaterInfo(string theaterID)
        {

            TheaterRequest input = new TheaterRequest { RequestedTheater = Convert.ToInt32(theaterID) };

            TheaterReply reply = await theaterClient.GetTheaterInfoAsync(input);

            Theater theater = new Theater(reply.ID, reply.TheaterName, reply.Location, reply.Contact, reply.Address);

            //Im sending this info to the MoreDetails view
            Program.ViewTheaterDetails.txtBoxTeather.Text = theater.TheaterName;
            Program.ViewTheaterDetails.txtBoxLocation.Text = theater.Location;
        }
    }
}