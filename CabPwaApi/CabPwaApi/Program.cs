// Program.cs
using CabPwaApi;
using CabPwaApi.Models.Office;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Events;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// ����������� Serilog ��� �����������
builder.Host.UseSerilog(
    (context, services, configuration) => configuration
        .WriteTo.Console()                                                             // ���� � �������
        .WriteTo.File(Utils.GetLogFileName(), rollingInterval:RollingInterval.Day)     // ���� � ���� �� ����
        .Enrich.FromLogContext()
        .Enrich.WithProperty("Application", "CabPwaApi")
        // ����� ���������� ���� Microsoft-�����
        .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore.Hosting", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore.Mvc", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore.Routing", LogEventLevel.Warning));

// �������� ������ ����������� � ������� ���� ������
var officeConnectionString = builder.Configuration.GetConnectionString(Utils.OfficeDBConnectionStringName);

// Add services to the container.

// ��������� ��������������
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)
        )
    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ������������ ����������� � ��
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
