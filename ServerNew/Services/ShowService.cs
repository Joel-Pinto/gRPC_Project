using ServerNew.Data;
using ServerNew.Models;
using Grpc.Core;

namespace ServerNew.Services
{
    public class ShowService : SendShow.SendShowBase
    {
        private readonly ILogger<ShowService> _logger;
        private readonly TheatersContext _context;

        public ShowService(ILogger<ShowService> logger, TheatersContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task LoadShow(LoadShownRequest request, IServerStreamWriter<ShowReply> responseStream, ServerCallContext context)
        {
            TheaterShow theaterShow = new TheaterShow();
            List<ShowReply> showList = new List<ShowReply>();
            
            //It needs to store the 3 values of a matching ID_show
            //It as to store the ID of TheaterShow, the ID_Show and ID_Theater
            var theaterShowList= _context.TheaterShows.Where(x => x.IdTheater == request.IDTheater).ToList();

            for (var i = 0; i < theaterShowList.Count; i++)
            {
                Show result = _context.Shows.Where(x => x.Id == theaterShowList[i].IdShow).FirstOrDefault();
                if(result != null)
                {
                    ShowReply show = new ShowReply()
                    {
                        ID = result.Id,
                        StartDate = result.StartDate,
                        EndDate = result.EndDate,
                        HasSeen = result.HasSeen,
                        Name = result.Name,
                        Synopse = result.Synopse
                    };

                    await responseStream.WriteAsync(show);
                }
            }
        }

        public override Task<ShowReply> GetShowInfo(ShowRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Sending Theater Information..\n\n");

            //I have it as amount of request but for now Ill say its the ID number
            var _show = _context.Shows.Where(x => x.Id == request.RequestedShow).FirstOrDefault();


            return Task.FromResult(new ShowReply
            {
                ID = _show.Id,
                Name= _show.Name,
                Synopse = _show.Synopse,
                StartDate = _show.StartDate,
                EndDate = _show.EndDate,
                HasSeen = _show.HasSeen
            });
        }

    }
}
