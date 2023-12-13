using Domain.Models;
using Domain.Service.Implementation;
using Domain.Service.Interfaces;
using Domain.Service.Interfaces.RepositoryInterfaces;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.
builder.Services.AddOptions();
builder.Services.Configure<UrlStoreDatabaseSettings>(
    builder.Configuration.GetSection("UrlStoreDatabase"));
builder.Services.AddTransient<IDomainService, DomainService>();
builder.Services.AddTransient<IMongoRepository, MongoRepository>();

// builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblyContaining(typeof(CreateUrlRecordCommand)));

var assembly = AppDomain.CurrentDomain.Load("Application");
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();