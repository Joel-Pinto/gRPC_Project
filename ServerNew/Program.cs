using Microsoft.EntityFrameworkCore;
using ServerNew.Services;
using ServerNew.Data;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TheatersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TheatersContext")));

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<TheaterService>();
app.MapGrpcService<ShowService>();
app.MapGrpcService<SessionService>();
app.MapGrpcService<UserService>();
app.MapGrpcService<ReferenceService>();
app.MapGrpcService<TicketService>();
app.MapGrpcService<WalletService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
