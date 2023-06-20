using ServerNew.Data;
using ServerNew.Models;
using Grpc.Core;

namespace ServerNew.Services
{
    public class SessionService : SendSession.SendSessionBase
    {
        private readonly ILogger<SessionService> _logger;
        private readonly TheatersContext _context;

        public SessionService(ILogger<SessionService> logger, TheatersContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task SessionByShow(LoadByShowRequest request, IServerStreamWriter<SessionReply> responseStream, ServerCallContext context)
        {
            List<SessionReply> sessionList = new List<SessionReply>();

            var resultList = _context.Sessions.Where(x => x.IdShow == request.IDShow).ToList();

            foreach (Session _session in resultList)
            {
                sessionList.Add(new SessionReply
                {
                    ID = _session.Id,
                    Date = Convert.ToString(_session.Date),
                    StartHour = Convert.ToString(_session.StartHour),
                    EndHour = Convert.ToString(_session.EndHour),
                    TotalSeats = _session.TotalSeats,
                    AvailableSeats = _session.AvailableSeats
                });
            }

            foreach (var session in sessionList)
            {
                await responseStream.WriteAsync(session);
            }
        }

        //This returns all the info I have inside the table Session, to the client
        public override async Task LoadSession(SessionLoadRequest request, IServerStreamWriter<SessionReply> responseStream, ServerCallContext context)
        {
            List<SessionReply> result = new List<SessionReply>();

            foreach (Session _session in _context.Sessions)
            {
                result.Add(new SessionReply
                {
                    ID = _session.Id,
                    Date = Convert.ToString(_session.Date),
                    StartHour = Convert.ToString(_session.StartHour),
                    EndHour = Convert.ToString(_session.EndHour),
                    TotalSeats = _session.TotalSeats,
                    AvailableSeats = _session.AvailableSeats
                });
            }

            foreach (var session in result)
            {
                await responseStream.WriteAsync(session);
            }
        }

        //This returns a specific Session connected to the ID sent from the client
        public override Task<SessionReply> GetSessionInfo(SessionRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Sending Session Information..\n\n");

            //I have it as amount of request but for now Ill say its the ID number
            var _session = _context.Sessions.Where(x => x.Id == request.RequestedSession).FirstOrDefault();


            return Task.FromResult(new SessionReply
            {
                ID = _session.Id,
                Date = Convert.ToString(_session.Date),
                StartHour = _session.StartHour,
                EndHour = _session.EndHour,
                TotalSeats = _session.TotalSeats,
                AvailableSeats = _session.AvailableSeats
            });
        }
    }
}
