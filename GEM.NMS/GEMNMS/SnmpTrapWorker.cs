using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace NmsService
{
    public class SnmpTrapWorker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var receiver = new SnmpTrapReceiver();
            await Task.Run(() => receiver.StartListening(), stoppingToken);
        }
    }
}

