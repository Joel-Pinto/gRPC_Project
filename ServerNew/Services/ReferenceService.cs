using ServerNew.Data;
using Grpc.Core;

namespace ServerNew.Services
{
    public class ReferenceService : SendReference.SendReferenceBase
    {
        private readonly ILogger<ReferenceService> _logger;
        private readonly TheatersContext _context;

        public ReferenceService(ILogger<ReferenceService> logger, TheatersContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override Task<ReferenceReply> GetReferenceInfo(ReferenceRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Sending Theater Information..\n\n");

            //I have it as amount of request but for now Ill say its the ID number
            var _references = _context.References.Where(x => x.Id == request.RequestedReference).FirstOrDefault();


            return Task.FromResult(new ReferenceReply
            {
                ID = _references.Id,
                Reference = Convert.ToInt32(_references.Reference1),
                Name = _references.Name
            });
        }
    }
}