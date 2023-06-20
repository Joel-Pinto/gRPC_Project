using Grpc.Core;
using ServerNew.Data;
using ServerNew.Models;

namespace ServerNew.Services
{
    public class TheaterService : SendTheater.SendTheaterBase
    {
        private readonly ILogger<TheaterService> _logger;
        private readonly TheatersContext _context;

        public TheaterService(ILogger<TheaterService> logger, TheatersContext context)
        {
            _logger = logger;
            _context = context;
        }


        public override async Task LoadTheater(TheaterLoadRequest request,IServerStreamWriter<TheaterReply> responseStream, ServerCallContext context)
        {
            //First we are going to count the number of theaters we have present in the database to send
            //int numbOfResults = _context.Theaters.Where(x => x.Id != null).Count();

            List<TheaterReply> result = new List<TheaterReply>();
            
            foreach(Theater _theater in _context.Theaters)
            {
                result.Add(new TheaterReply
                {
          
                    ID = _theater.Id,
                    TheaterName = _theater.Name,
                    Location = _theater.Location,
                    Contact = _theater.Contact,
                    Address = _theater.Address
                });
            }

            foreach (var theater in result)
            {
                await responseStream.WriteAsync(theater);
            }
        }


        public async override Task<TheaterReply> GetTheaterInfo(TheaterRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Sending Theater Information..\n\n");

            //I have it as amount of request but for now Ill say its the ID number
            var _theater = _context.Theaters.Where(x => x.Id == request.RequestedTheater).FirstOrDefault();

            return await Task.FromResult(new TheaterReply
            {
                ID = _theater.Id,
                TheaterName = _theater.Name,
                Location = _theater.Location,
                Contact = _theater.Contact,
                Address = _theater.Address
            });
        }

        public override Task<AddTheaterReply> AddTheaterInfo(AddTheaterRequest request, ServerCallContext context)
        {
            var theater = _context.Theaters.Add(new Theater()
            {
                Name = request.NameTheater,
                Location = request.Location,
                Contact = request.Contact,
                Address = request.Address
            });

            var result = _context.SaveChanges();

            if (result != null)
            {
                return Task.FromResult(new AddTheaterReply
                {
                    ReplyMessage = "O Teatro foi adicionado com sucesso"
                });
            }

            return Task.FromResult(new AddTheaterReply
            {
                ReplyMessage = "Ocorreu um erro ao adicionar o teatro"
            });
        }
    }
}