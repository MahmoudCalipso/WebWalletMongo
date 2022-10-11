
using Microsoft.Extensions.Options;
using System.Configuration;
using WebWallet.Repositories;
using WebWallet.Settings;
using ConfigurationManager = Microsoft.Extensions.Configuration.ConfigurationManager;

var builder = WebApplication.CreateBuilder(args);
// allows both to access and to set up the config
ConfigurationManager configuration = builder.Configuration; 
IWebHostEnvironment environment = builder.Environment;
// Connection Instance 
builder.Services.Configure<MongoDbSettings>(con => configuration.GetSection("MongoDbSettings").Bind(con));
builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider =>
    (IMongoDbSettings)serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

// Add services to the container.
builder.Services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
