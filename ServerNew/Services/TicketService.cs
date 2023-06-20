using Grpc.Core;
using ServerNew.Data;
using ServerNew.Models;

namespace ServerNew.Services
{
    public class TicketService : SendTicket.SendTicketBase
    {
        private readonly ILogger<TicketService> _logger;
        private readonly TheatersContext _context;

        public TicketService(ILogger<TicketService> logger, TheatersContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override Task<TicketReply> GetTicketInfo(TicketRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Sending Ticket Information..\n\n");

            //I have it as amount of request but for now Ill say its the ID number
            var _ticket = _context.Tickets.Where(x => x.Id == request.RequestedTicket).FirstOrDefault();


            return Task.FromResult(new TicketReply
            {
                ID = _ticket.Id,
                Date = Convert.ToString(_ticket.Date),
                Hour = Convert.ToString(_ticket.Hour),
                NumberTickets = _ticket.NumberTickets,
                IsItPaid = _ticket.IsItPaid
            });
        }

        public override Task<BuyTicketReply> BuyTicket(BuyTicketRequest request, ServerCallContext context)
        {
            Random random = new Random();
            _logger.LogInformation("Processing Buying Ticket..\n\n");

            //First I need to get the session of the ticket we are buying
            Session _ticket = _context.Sessions.Where(x => x.Id == request.IDSession).FirstOrDefault();
            Show _show = _context.Shows.Where(x => x.Id == _ticket.IdShow).FirstOrDefault();


            //I need to create a reference now
            Reference NewReference = new Reference {

                Name = "Ticket bought at " + Convert.ToString(DateTime.Now),
                Reference1 = random.Next(10000, 789567)

            };

            var reference = _context.References.Add(NewReference);
            _context.SaveChanges();

            int IDReference = NewReference.Id;


            //Before a create my new Ticket I must make him pay the ticket
            Wallet userWallet = _context.Wallets.SingleOrDefault(x => x.IdUser == request.UserID);

            if(userWallet != null)
            {
                userWallet.WalletAmount -= _show.Price * request.NumberOfTickets;
                _context.SaveChanges();
            }
            else
            {
                //the user was not found in the database
                return Task.FromResult(new BuyTicketReply { Success = false });
            }


            if (userWallet.WalletAmount < 0)
            {
                Ticket NewTicket = new Ticket
                {
                    IdSession = _ticket.Id,
                    //I have no clue if this will work
                    IdReference = IDReference,
                    Date = DateTime.Now,
                    Hour = DateTime.Today,
                    NumberTickets = request.NumberOfTickets,
                    IsItPaid = 0
                };

                var newTicket = _context.Tickets.Add(NewTicket);
                _context.SaveChanges();

                int IDTicket = NewTicket.Id;

                var ticketUser = _context.UserTickets.Add(new UserTicket()
                {
                    IdSession = request.IDSession,
                    //I have no clue if this will work
                    IdTicket = IDTicket,
                    IdUser = request.UserID
                });
                _context.SaveChanges();

                return Task.FromResult(new BuyTicketReply { Success = false });
            }
            else
            {
                Ticket NewTicket = new Ticket
                {
                    IdSession = _ticket.Id,
                    //I have no clue if this will work
                    IdReference = IDReference,
                    Date = DateTime.Now,
                    Hour = DateTime.Today,
                    NumberTickets = request.NumberOfTickets,
                    IsItPaid = 0
                };

                var newTicket = _context.Tickets.Add(NewTicket);
                _context.SaveChanges();

                int IDTicket = NewTicket.Id;

                var ticketUser = _context.UserTickets.Add(new UserTicket()
                {
                    IdSession = request.IDSession,
                    //I have no clue if this will work
                    IdTicket = IDTicket,
                    IdUser = request.UserID
                });
                _context.SaveChanges();

                return Task.FromResult(new BuyTicketReply { Success = true });
            }
        }

        public override async Task LoadTickets(LoadTicketsRequest request, IServerStreamWriter<LoadTicketsReply> responseStream, ServerCallContext context)
        {
            LoadTicketsReply reply;

            UserTicket ticketsToUser = new UserTicket();

            //I dont know if this is only going to give me one value :c
            //while (ticketsToUser != null)
            //{
            ticketsToUser = _context.UserTickets.Where(x => x.IdUser == request.UserID).FirstOrDefault();
            Ticket _ticket = _context.Tickets.Where(x => x.Id == ticketsToUser.IdTicket).FirstOrDefault();
            Session session = _context.Sessions.Where(x => x.Id == _ticket.IdSession).FirstOrDefault();
            Show show = _context.Shows.Where(x => x.Id == session.IdShow).FirstOrDefault();

            reply = new LoadTicketsReply
            {
                ShowName = show.Name,
                Date = _ticket.Date.ToString(),
                Hour = _ticket.Hour.ToString(),
                NumbOfTickets = _ticket.NumberTickets,
                IsItPaid = _ticket.IsItPaid,
            };

            await responseStream.WriteAsync(reply);
            //}
        }
    }
}