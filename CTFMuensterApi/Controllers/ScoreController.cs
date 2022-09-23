using System;
using System.Collections.Generic;
using CTFMuenster.Api.Model;
using CTFMuensterApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;

namespace CTFMuensterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ScoreController : ControllerBase
{
    private readonly IDataService _dataService;

    private readonly ILogger<ScoreController> _logger;

    public ScoreController(ILogger<ScoreController> logger, IDataService dataService)
    {
        _logger = logger;
        _dataService = dataService;

    }


    [HttpGet]
    public IEnumerable<Score> GetScore([FromQuery(Name = "since")] DateTimeOffset? since)
    {
        return _dataService.GetScores(since);
    }

    
    [HttpGet]
    [Route("{userId}")]
    public Score GetScore(Guid userId, [FromQuery(Name = "since")] DateTimeOffset? since)
    {
        return _dataService.GetScores(since).Where(x => x.User.Id.Equals(userId)).First();
    }
}