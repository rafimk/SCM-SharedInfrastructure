using Microsoft.AspNetCore.Mvc;
using SCM.SharedEnabler.Messaging;
using SCM.SharedEnabler.Time;
using SCM.Testing.Api.Events;
using SCM.Testing.Api.Messages;

namespace SCM.Testing.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

   
    private readonly IMessageBroker _messageBroker;
    private readonly IClock _clock;
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly MessageProducer _messageProducer;

    public WeatherForecastController(IClock clock, IMessageBroker messageBroker, 
        MessageProducer messageProducer, ILogger<WeatherForecastController> logger)
    {
        _clock = clock;
        _messageBroker = messageBroker;
        _messageProducer = messageProducer;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
    
    [HttpPost()]
    public async Task Post()
    {
        var cancellationToken = new CancellationToken();
        var accountCreatedEvent = new AccountCreated(Guid.NewGuid(), Guid.NewGuid(), "AED", 100);
        await _messageBroker.PublishAsync(accountCreatedEvent, cancellationToken);
        await _messageProducer.PublishAsync(@accountCreatedEvent);
    }
}