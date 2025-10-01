// Program.cs
using CabPwaApi;
using CabPwaApi.Models.Office;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

// Настраиваем Serilog для логирования
builder.Host.UseSerilog(
    (context, services, configuration) => configuration
        .WriteTo.Console()                                                             // Логи в консоль
        .WriteTo.File(Utils.GetLogFileName(), rollingInterval:RollingInterval.Day)     // Логи в файл по дням
        .Enrich.FromLogContext()
        .Enrich.WithProperty("Application", "CabPwaApi")
        // Явное подавление всех Microsoft-логов
        .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore.Hosting", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore.Mvc", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore.Routing", LogEventLevel.Warning));

// Получаем Строку подключения к офисной базе данных
var officeConnectionString = builder.Configuration.GetConnectionString(Utils.OfficeDBConnectionStringName);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Конфигурация подключения к БД
builder.Services.AddDbContext<OfficeDBContext>(options =>
{
    options.UseSqlServer(officeConnectionString,
        builder => builder.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null));
});

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
