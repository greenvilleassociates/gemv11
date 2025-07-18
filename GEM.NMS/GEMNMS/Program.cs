using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Threading;
using System.Threading.Tasks;

namespace NmsService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService(options =>
                {
                options.ServiceName = "GEMNMS"; // Set your service name here
                })
            .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<SnmpTrapWorker>();
                 });
            }
    }

