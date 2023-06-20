using Grpc.Core;
using ServerNew.Data;
using ServerNew;
using ServerNew.Models;

namespace ServerNew.Services
{
    public class UserService : SendUser.SendUserBase
    {
        private readonly ILogger<UserService> _logger;
        private readonly TheatersContext _context;

        public UserService(ILogger<UserService> logger, TheatersContext context)
        {
            _logger = logger;
            _context = context;
        }

        public override Task<UserReply> GetUserInfo(UserRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Retrieving user info..\n\n");

            //I have it as amount of request but for now Ill say its the ID number
            var _user = _context.Users.Where(x => x.Id == request.RequestedUser).FirstOrDefault();

            if (_user != null)
            {
                return Task.FromResult(new UserReply
                {
                    ID = _user.Id,
                    Name = _user.Name,
                    Location = _user.Location,
                    Age = _user.Age,
                    IsInserted = true
                });
            }
            else
            {
                return Task.FromResult(new UserReply
                {
                    IsInserted=false
                });
            }
        }

        public override Task<InsertUserReply> InsertUser(InsertUserRequest request, ServerCallContext context)
        {
            var _user = _context.Users.Where(x => x.UserName == request.UserName).FirstOrDefault();

            if (_user == null)
            {
                var user = _context.Users.Add(new User()
                {
                    Name = request.Name,
                    UserName = request.UserName,
                    Location = request.Location,
                    Age = request.Age,
                    IdRole = request.Role
                });

                var result = _context.SaveChanges();

                if(result!=null)
                {
                    _logger.LogInformation("A User was added to the DB!\n\n");

                    return Task.FromResult(new InsertUserReply
                    {
                        IsInserted = true
                    });
                }
                else 
                { 
                    _logger.LogInformation("An error as occurred inserting a User to the DB\n\n");
                    
                    return Task.FromResult(new InsertUserReply
                    {
                        IsInserted = false
                    });
                }
            }
            else
            {
                _logger.LogInformation("An error as occurred inserting a User to the DB\n\n");

                return  Task.FromResult(new InsertUserReply
                {
                    IsInserted = false
                });
            }
        }

        //Function to verify if the user that wants to login exists
        //Im not sure if _user gets a null when there isnt results for what is looking for
        public override async Task<UserVerifyReply> VerifyUser(UserVerifyRequest request, ServerCallContext context)
        {
            var _user = _context.Users.Where(x => x.UserName == request.Username).FirstOrDefault();

            if(_user != null)
            {
                return await Task.FromResult(new UserVerifyReply { DoesExist = true, UserID = _user.Id });
            }
            else
            {
                return await Task.FromResult(new UserVerifyReply { DoesExist = false });
            }
        }
    }
}