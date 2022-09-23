using CTFMuenster.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using CTFMuensterApi.Data;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;

namespace CTFMuensterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FlagController : ControllerBase
{
    private readonly IDataService _dataService;

    private readonly ILogger<FlagController> _logger;

    public FlagController(ILogger<FlagController> logger, IDataService dataService)
    {
        _logger = logger;
        _dataService = dataService;
    }

    [HttpGet]
    public IEnumerable<Flag> Get()
    {
        return _dataService.GetFlags();
    }

    [HttpGet]
    [Route("{id}")]
    public Flag GetFlag(Guid id)
    {
        return _dataService.GetFlag(id);
    }

    [HttpPost]
    [Route("/add")]
    public Flag AddFlag(Flag flag)
    {
        return _dataService.AddFlag(flag);
    }
}
