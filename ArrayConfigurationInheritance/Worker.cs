using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ArrayConfigurationInheritance
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly AppSettings _settings;
        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            _settings = configuration.GetSection("AppSettings").Get<AppSettings>();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine($"MyArray0: \t {string.Join(", ", _settings.MyArray0 ?? Array.Empty<string>())}");
            Console.WriteLine($"MyArray1: \t {string.Join(", ", _settings.MyArray1 ?? Array.Empty<string>())}");
            Console.WriteLine($"MyArray2: \t {string.Join(", ", _settings.MyArray2 ?? Array.Empty<string>())}");
            Console.WriteLine($"MyArray3: \t {string.Join(", ", _settings.MyArray3 ?? Array.Empty<string>())}");
            await Task.CompletedTask;
        }
    }
}
