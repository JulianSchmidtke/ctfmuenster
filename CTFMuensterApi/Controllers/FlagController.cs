using CTFMuenster.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace CTFMuensterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FlagController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<FlagController> _logger;

    public FlagController(ILogger<FlagController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFlag")]
    public IEnumerable<Flag> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Flag
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
