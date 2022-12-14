using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TUT1.API.Data;
using TUT1.API.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        //injecting the DB Context into services collection
        builder.Services.AddDbContext<TUT1DBContext>(Options =>
        {
            Options.UseSqlServer(builder.Configuration.GetConnectionString("TUT1"));
        }
        );


        builder.Services.AddScoped<IRegionRepository, RegionRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        builder.Services.AddAutoMapper(typeof(Program).Assembly);

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}