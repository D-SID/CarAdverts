using CarAdverts.Core.Interface;
using CarAdverts.Core.Services;
using CarAdverts.Repository.Interface;
using CarAdverts.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); // need install sql

        //builder.Services.AddDbContext<ApplicationDbContext>(options =>
        //options.UseSqlServer(connectionString));

        builder.Services.AddScoped<ICarAdvertService, CarAdvertService>();
        builder.Services.AddScoped<ICarAdvertRepository, CarAdvertRepository>();

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
    }
}