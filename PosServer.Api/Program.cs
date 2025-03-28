using PosServer.Core;
using PosServer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Serilog;
using PosServer.Implementation;
using PosServer.Application.UseCases.Queries;
using PosServer.Implementation.UseCases.Queries;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var settings = new AppSettings();
builder.Configuration.Bind(settings);
builder.Services.AddSingleton(settings);

builder.Host.UseSerilog((context, configuration) => 
    configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddDbContext<PosServerDbContext>(options =>
    options.UseSqlServer(settings.ConnectionStrings.PosServer));


builder.Services.AddTransient<UseCaseHandler>();

builder.Services.AddTransient<IGetTerminalsQuery, EfGetTerminalsQuery>();
builder.Services.AddTransient<IGetSettlementQuery, EfGetSettementQuery>();
builder.Services.AddTransient<IGetPaymentResponseQuery, EfGetPaymentResponseQuery>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
