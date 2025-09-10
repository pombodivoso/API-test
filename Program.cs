using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using CuriTrip.Models;
using CuriTrip.Services.JWT;
using CuriTrip.UseCases.CreatePasseio;
using CuriTrip.UseCases.EditPasseio;
using CuriTrip.UseCases.Login;
using CuriTrip.UseCases.SeePasseio;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CuriTripDbContext>(options =>
{
    var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");
    options.UseSqlServer(sqlConn);
});

var jwtSecret = Environment.GetEnvironmentVariable("JWT_SECRET");
var keyBytes = Encoding.UTF8.GetBytes(jwtSecret);
var key = new SymmetricSecurityKey(keyBytes);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidIssuer = "CuriTrip",
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = key,
    };
});

builder.Services.AddSingleton<IJWTService, JWTService>();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/", () => "Hello World!");

app.Run();
