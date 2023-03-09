using Microsoft.EntityFrameworkCore;
using OneToOne.Models;
using OneToOne.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
var config = builder.Configuration.GetSection("Connection");
builder.Services.AddDbContext<SchoolDbContext>(option => option.UseNpgsql(config["connect"]));
builder.Services.AddScoped<IStudentService, StudentsService>();
builder.Services.AddScoped<SchoolDbContext>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
