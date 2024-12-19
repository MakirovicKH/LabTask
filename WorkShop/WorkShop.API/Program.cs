
using Microsoft.EntityFrameworkCore;
using WorkShop.DAL;
using Microsoft.Extensions.DependencyInjection;
using WorkShop.DAL.Data;
using WorkShop.DAL.Interfaces;
using WorkShop.DAL.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// DbContext konfiqurasiyas?
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Generic Repository üçün qeydiyyat
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Business Logic Layer servisl?rinin qeydiyyat?
builder.Services.AddScoped<WorkshopService>();

// Controller-l?ri aktivl??dirir
builder.Services.AddControllers();

// Swagger UI (API s?n?dl??dirm? üçün)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

