using Microsoft.EntityFrameworkCore;
using ViewEvents.Persistence.Contexts;
using ViewEvents.Persistence.Interfaces;
using ViewEvents.Persistence.Persistencies;
using ViewEvents.Services.Interfaces;
using ViewEvents.Services.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ViewEventContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ConnectionDevelopment")));

builder.Services.AddTransient<IPersistenceGeneral, PersistenceGeneral>();
builder.Services.AddScoped<IPersistenceEvent, PersistenceEvent>();
builder.Services.AddTransient<IEventService, EventService>();
//builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors(c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
