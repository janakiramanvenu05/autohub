using AutoHub.Application.Interfaces;
using AutoHub.Application.Services;
using AutoHub.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("AutoHubDb")
    ?? throw new InvalidOperationException("Connection string 'AutoHubDb' was not found.");
builder.Services.AddDbContext<VehicleDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<IVehicleService, VehicleService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
