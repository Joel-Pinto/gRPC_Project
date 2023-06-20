using Grpc.Net.Client;
using ClientNew.Models;
using Grpc.Core;


namespace ClientNew.Controllers
{
    class ControllerShow
    {
        
        private SendShow.SendShowClient ShowClient { get; set; }


        public async Task<List<int>> LoadShow(string theaterID)
        {
            List<int> idShows = new List<int>();

            LocalHost localHost = new LocalHost();

            var channel = GrpcChannel.ForAddress(localHost.Address);
            //Storing my connection ID
            ShowClient = new SendShow.SendShowClient(channel);


            LoadShownRequest inputTheater = new LoadShownRequest { IDTheater = Convert.ToInt32(theaterID) };
            var call = ShowClient.LoadShow(inputTheater);

            while (await call.ResponseStream.MoveNext())
            {
                ShowReply currentShow = call.ResponseStream.Current;
             
                Program.ViewTheaterDetails.listBoxShow.Items.Add(currentShow.Name + " " + currentShow.Synopse + " " + currentShow.StartDate + " " + currentShow.EndDate);


                idShows.Add(currentShow.ID);
            }
            return idShows;
        }
    }
}
