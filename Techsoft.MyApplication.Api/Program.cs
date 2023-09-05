using Microsoft.EntityFrameworkCore;
using MyApplication.Contexto;
using MyApplication.Contratos;
using MyApplication.Entidades;
using MyApplication.Repositorios;
using Techsoft.MyApplication.Aplicacion.Servicios;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //var connectionString = builder.Configuration
        //    .GetConnectionString("SQLServer");

        //builder.Services.AddDbContext<Context>(options =>
        //    options.UseSqlServer(connectionString));

        var connectionString = builder.Configuration
            .GetConnectionString("SQLite");

        builder.Services.AddDbContext<Context>(options =>
            options.UseSqlite(connectionString));

        builder.Services.AddScoped<IRepositorio<Cliente>, RepositorioSQLServer<Cliente>>();

        builder.Services.AddScoped<ClienteService>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
    }
}