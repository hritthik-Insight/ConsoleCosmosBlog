using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleCosmos.Data;
using SimpleCosmos.Service;
using SimpleCosmos.View;
using System.Threading.Tasks;

namespace SimpleCosmos
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            var context = services.GetRequiredService<BlogContext>();
            await context.Database.EnsureCreatedAsync();

            var userInteraction = services.GetRequiredService<UserInteraction>();
            await userInteraction.RunAsync();
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<BlogContext>();
                    services.AddTransient<BlogService>();
                    services.AddTransient<UserInteraction>();
                });
    }
}