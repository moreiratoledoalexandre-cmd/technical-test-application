using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StatisticsAPI.DBContext;
using StatisticsAPI.Entity;
using StatisticsAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.Configure<DeviceRegisterAPIConfig>(options => builder.Configuration.GetSection("DeviceRegisterAPIConfig").Bind(options));
builder.Services.AddDbContext<LogHistoryContext>(options =>
{
    var connectionstring = "mongodb://root:password@localhost:27017/?authSource=admin";
    var database = "log_statistics_db";
    options.UseMongoDB(connectionstring, database);
});
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IStatisticsService, StatisticsService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.UseHttpsRedirection();
app.Run();

