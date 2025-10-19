using DeviceRegistrationAPI.DBContext;
using DeviceRegistrationAPI.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDeviceRegistrationService, DeviceRegistrationService>();

builder.Services.AddDbContext<DeviceRegistrationContext>(options =>
{
    var connectionstring = "mongodb://root:password@mongo:27017/?authSource=admin";
    var database = "device_register_db";
    options.UseMongoDB(connectionstring, database);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.UseHttpsRedirection();
app.UseHttpsRedirection();
app.Run();

