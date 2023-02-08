using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proiect_DAW___Iftichi_Calin.Data;
using Proiect_DAW___Iftichi_Calin.Helpers;
using Proiect_DAW___Iftichi_Calin.Helpers.JwtToken;
using Proiect_DAW___Iftichi_Calin.Helpers.JwtUtils;
using Proiect_DAW___Iftichi_Calin.Repositories.SediuRepository;
using Proiect_DAW___Iftichi_Calin.Repositories.UtilizatorRepository;
using Proiect_DAW___Iftichi_Calin.Services.DemoService;
using Proiect_DAW___Iftichi_Calin.Services.UserService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ProiectContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

//repositories
builder.Services.AddTransient<IJobRepository, JobRepository>();
builder.Services.AddTransient<IUtilizatorRepository, UtilizatorRepository>();

//services
builder.Services.AddTransient<IJobService, JobService>();
builder.Services.AddTransient<IUtilizatorService, UtilizatorService>();
builder.Services.AddTransient<IJwtUtils, JwtUtils>();

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
