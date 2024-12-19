using CleanCar.Infrastructure.Data;
using CleanCar.Application.IService;
using CleanCar.Application.Service;
using Microsoft.EntityFrameworkCore;
using CleanCar.Infrastructure.IRepository;
using CleanCar.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<ICidadeRepository, CidadeRepository>();
builder.Services.AddTransient<ICidadeService, CidadeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
