using MiastaMieścinyMiasteczka.Data;
using MiastaMieścinyMiasteczka.Data.Interfaces;
using MiastaMieścinyMiasteczka.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CityContext>(options =>
     options.UseInMemoryDatabase(databaseName: "InMemoryCityDb"));
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());





var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
