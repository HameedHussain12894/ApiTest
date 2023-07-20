using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace CTest.Models
{
    public class SchedulerService : BackgroundService
    {
        private readonly ILogger<SchedulerService> _logger;
        private readonly List<LogEntry> _logs;
        private readonly object _lock = new object();

        public SchedulerService(ILogger<SchedulerService> logger)
        {
            _logger = logger;
            _logs = new List<LogEntry>();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var currentTime = DateTime.Now;
                var logEntry = new LogEntry { Timestamp = currentTime, Message = $"Scheduled task executed at {currentTime}" };

                lock (_lock)
                {
                    _logs.Add(logEntry);
                }

                await Task.Delay(TimeSpan.FromSeconds(60), stoppingToken);
            }
        }

        public IReadOnlyList<LogEntry> GetLogs()
        {
            lock (_lock)
            {
                return _logs.AsReadOnly();
            }
        }
    }
}