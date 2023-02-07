using Microsoft.EntityFrameworkCore;
using JoloLoverServices.Data.Interfaces;
using JoloLoverServices.Data.DataGateway;
using JoloLoverServices.Data;
using JoloLoverServices.Interfaces;
using JoloLoverServices.Services;

namespace JoloLoverServices;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("MSSqlConnection"));
        });

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add dataGateway here
        builder.Services.AddScoped<ITransactionSqlDataGateway, TransactionSqlDataGateway>();
        builder.Services.AddScoped<ICategorySqlDataGateway, CategorySqlDataGateway>();

        // Add services here
        builder.Services.AddScoped<ITransactionService, TransactionService>();
        builder.Services.AddScoped<ICategoryService, CategoryService>();


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
    }
}
