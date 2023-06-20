using Grpc.Core;
using ServerNew.Data;
using ServerNew;
using ServerNew.Models;

namespace ServerNew.Services
{
    public class WalletService : SendWalletInfo.SendWalletInfoBase
    {
        private readonly ILogger<WalletService> _logger;
        private readonly TheatersContext _context;

        public WalletService(ILogger<WalletService> logger, TheatersContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override async Task<UpdateReply> UpDateWallet(UpdateRequest request, ServerCallContext callContext)
        {
            _logger.LogInformation("Updating Wallet..\n\n");

            var _userWallet = _context.Wallets.Where(x => x.IdUser == request.UserId).FirstOrDefault();

            return await Task.FromResult(new UpdateReply{ WalletFunds = Convert.ToDouble(_userWallet.WalletAmount)});
        }
    }
}
