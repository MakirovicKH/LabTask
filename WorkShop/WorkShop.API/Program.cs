
using Microsoft.EntityFrameworkCore;
using WorkShop.DAL;
using Microsoft.Extensions.DependencyInjection;
using WorkShop.DAL.Data;
using WorkShop.DAL.Interfaces;
using WorkShop.DAL.Implementations;
using WorkShop.API.Services.Implementations;
using WorkShopModel.Models;
using WorkShop.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRepository<WorkShopItem>, Repository<WorkShopItem>>();
builder.Services.AddScoped<IWorkShopServices<WorkShopItem>, WorkShopServices>();


builder.Services.AddControllers();

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

