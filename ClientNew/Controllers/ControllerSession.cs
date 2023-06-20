using Grpc.Net.Client;
using ClientNew.Models;
using Grpc.Core;

namespace ClientNew.Controllers
{
    class ControllerSession
    {
        private SendSession.SendSessionClient SessionClient { get; set; }

        public List<int> ListShows { get; set; }

        public ControllerSession()
        {

        }

        //Nesta funcao ainda me falta passar o ID ou IDs das sessoes que quero mostrar
        //porque pode haver mais do que um show associado a cada teatro
        //logo mais do que um conjunto de sessoes a mostrar
        public async Task LoadSession()
        {
            LocalHost ip = new LocalHost();

            var channel = GrpcChannel.ForAddress(ip.Address);
            //Storing my connection ID
            SessionClient = new SendSession.SendSessionClient(channel);

            var call = SessionClient.LoadSession(new SessionLoadRequest());

            while (await call.ResponseStream.MoveNext())
            {
                var currentSession = call.ResponseStream.Current;

                Program.ViewTheaterDetails.lstBoxSessoes.Items.Add(currentSession.StartHour + "   " + currentSession.EndHour + "   " + currentSession.TotalSeats + "   " + currentSession.AvailableSeats);
            }
        }

        public async Task SessionByShow(int idShow)
        {
            LocalHost ip = new LocalHost();
            List<int> IDShow = new List<int>();

            var channel = GrpcChannel.ForAddress(ip.Address);
            //Storing my connection ID
            SessionClient = new SendSession.SendSessionClient(channel);

            var stream = SessionClient.SessionByShow(new LoadByShowRequest { IDShow = idShow});

            while(await stream.ResponseStream.MoveNext())
            {
                var response = stream.ResponseStream.Current;

                IDShow.Add(response.ID);
                ListShows = IDShow;

                Program.ViewTheaterDetails.lstBoxSessoes.Items.Add("Data: " + response.Date + "Inicio/Fim: " + response.StartHour + response.EndHour +
                    "Lugares Totais: " + response.TotalSeats + "Disponíveis: " + response.AvailableSeats);
            }
        }


    }
}