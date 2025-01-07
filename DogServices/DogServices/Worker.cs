using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DogServices;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IConfiguration _configuration;
    private readonly DogSitter dogSitter;

    public Worker(ILogger<Worker> logger, IConfiguration configuration, DogSitter dogSitter) => (_logger, _configuration, this.dogSitter) = (logger, configuration, dogSitter);


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {Time}", DateTimeOffset.Now);
            dogSitter.EsciIlCane(_configuration["datadogurl"], _configuration["cani"]);
            await Task.Delay(30000, stoppingToken);
        }
    }
}
