using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using JoloLoverServices.Data.Interfaces;
using JoloLoverServices.Data.DataGateway;
using JoloLoverServices.Data;
using JoloLoverServices.Interfaces;
using JoloLoverServices.Services;
using JoloLoverServices.Managers.Interfaces;
using JoloLoverServices.Managers;
using JoloLoverServices.Factories.Interfaces;
using JoloLoverServices.Factories;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using JoloLoverServices.Models;

namespace JoloLoverServices;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        var corsConfigName = "CORS-Config";

        // Add services to the container.
        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: corsConfigName, policy =>
            {
                policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
            });
        });

        builder.Services.AddControllers();

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("MSSqlConnection"));
        });

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AuthTokenCreationParameters.SecretKey)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add dataGateway here
        builder.Services.AddScoped<ITransactionSqlDataGateway, TransactionSqlDataGateway>();
        builder.Services.AddScoped<ICategorySqlDataGateway, CategorySqlDataGateway>();
        builder.Services.AddScoped<IWalletSqlDataGateway, WalletSqlDataGateway>();
        builder.Services.AddScoped<IUserSqlDataGateway, UserSqlDataGateway>();

        // Add services here
        builder.Services.AddScoped<ITransactionService, TransactionService>();
        builder.Services.AddScoped<ICategoryService, CategoryService>();
        builder.Services.AddScoped<IWalletService, WalletService>();
        builder.Services.AddScoped<IUserService, UserService>();

        // Add managers
        builder.Services.AddScoped<IAuthManager, AuthManager>();

        // Add factories
        builder.Services.AddScoped<IClaimsFactory, ClaimsFactory>();
        builder.Services.AddScoped<ITokenFactory, TokenFactory>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors(corsConfigName);

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
