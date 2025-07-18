/*using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.WindowsServices;
using GEMAPI.Models;
using Enterprise.Controllers;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            c.RoutePrefix = string.Empty; // Optional, serve Swagger UI at root
        });

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapGvendorEndpoints();
        app.MapGcircuittypeEndpoints();
        app.MapGhostvmEndpoints();
        app.MapControllers();
    }
}

using Microsoft.AspNetCore.Hosting;

protected override void OnStart(string[] args)
{
    Task.Run(() =>
    {
        CreateHostBuilder(args).Build().Run();
    });
}

public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseUrls("http://localhost:5000");
            webBuilder.UseStartup<Startup>(); // Startup class configures your REST API
        });
}*/