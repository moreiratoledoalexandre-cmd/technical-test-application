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

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<DeviceRegistrationContext>(options =>
    {
        var connectionstring = "mongodb://root:password@localhost:27017/?authSource=admin";
        var database = "device_register_db";
        options.UseMongoDB(connectionstring, database);
    });
}
else
{
    builder.Services.AddDbContext<DeviceRegistrationContext>(options =>
    {
        var connectionstring = "mongodb://root:password@mongo:27017/?authSource=admin";
        var database = "device_register_db";
        options.UseMongoDB(connectionstring, database);
    });
}

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.UseHttpsRedirection();
app.UseHttpsRedirection();
app.Run();

