using CTFMuenster.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CTFMuensterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FlagController : ControllerBase
{
    public static readonly Flag[] Flags = new[]
    {
        new Flag(){
            Id=new Guid("d404eed3-5842-4d45-84b5-dce00b015dac"), 
            Description="Prinzipalmarkt",
            FlagName="Prinzipalmarkt",
            Location= new Location(51.962776004909124, 7.6282566472538615),
            Tags= Array.Empty<Tag>()},
        new Flag(){
            Id=new Guid("76d4fc1a-643c-4ec7-a876-a14cdec0980c"), 
            Description="Buddenturm",
            FlagName="Buddenturm",
            Location= new Location(51.96626699838519, 7.623065882679778),
            Tags=Array.Empty<Tag>()},
        new Flag(){
            Id=new Guid("ba529460-c0a1-428d-9239-9ae3442e18fb"), 
            Description="Davidwache",
            FlagName="Davidwache",
            Location= new Location(51.96646017686706, 7.6182496299172575),
            Tags=Array.Empty<Tag>()}
    };

    private readonly ILogger<FlagController> _logger;

    public FlagController(ILogger<FlagController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Flag> Get()
    {
        return Flags;
    }

    [HttpGet]
    [Route("{id}")]
    public Flag GetFlag(Guid id)
    {
        return Flags.Where(x => x.Id == id).First();
    }
}
