using GuerreroWebAPIFINAL.CORE.Interfaces;
using GuerreroWebAPIFINAL.CORE.Services;
using GuerreroWebAPIFINAL.INFRASTRUCTURE.Data;
using GuerreroWebAPIFINAL.INFRASTRUCTURE.Repositories;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var _config = builder.Configuration;
var connectionString = _config.GetConnectionString("DevConnection");

builder.Services.AddDbContext<GuerreroFinalCibertecContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddTransient<ICourseRepository, CourseRepository>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IEnrollmentRepository, EnrollmentRepository>();
builder.Services.AddTransient<IEnrollmentService, EnrollmentService>();


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
