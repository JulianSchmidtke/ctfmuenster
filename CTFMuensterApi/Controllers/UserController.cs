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
public class UserController : ControllerBase
{
    private readonly IDataService _dataService;

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger, IDataService dataService)
    {
        _logger = logger;
        _dataService = dataService;
    }

    [HttpGet]
    public IEnumerable<User> Get()
    {
        return _dataService.GetUsers();
    }

    [HttpGet]
    [Route("{id}")]
    public User GetUser(Guid id)
    {
        return _dataService.GetUser(id);
    }

    [HttpGet]
    [Route("{userId}/flags/")]
    public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId)
    {
        return _dataService.GetFlagsPerUser(userId);
    }

    [HttpGet]
    [Route("{userId}/flags/{flagId}")]
    public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId, Guid flagId)
    {
        return _dataService.GetFlagsPerUser(userId, flagId);
    }

    [HttpPost]
    [Route("{userId}/addflag")]
    public IEnumerable<UserFlag> PostFlagForUser(Guid userId, PostUserFlagRequest postUserFlagRequest)
    {
        User user = _dataService.GetUser(userId);
        Flag flag = _dataService.GetFlag(postUserFlagRequest.Id);

        UserFlag bla = _dataService.CreateUserFlag(new UserFlag()
        {
            UserId = user.Id,
            FlagId = flag.Id,
            Score = 10
        });

        return _dataService.GetFlagsPerUser(userId, postUserFlagRequest.Id);
    }

    [HttpGet]
    [Route("points")]
    public IEnumerable<UserFlag> GetPoints(int maxUsers, DateTimeOffset minimumDate, DateTimeOffset maximumDate)
    {
        return _dataService.GetPoints(maxUsers, minimumDate, maximumDate);
    }
}
