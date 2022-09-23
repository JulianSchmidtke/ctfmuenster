using CTFMuenster.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CTFMuensterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserFlagController : ControllerBase
{
    private static readonly UserFlag[] UserFlags = new[]
    {
        new UserFlag(){
            Id=new Guid(""),
            User=UserController.Users[0],
            Flag=FlagController.Flags[0],
            Active= true,
            Score=10},
        new UserFlag(){
            Id=new Guid(""),
            User=UserController.Users[0],
            Flag=FlagController.Flags[1],
            Active= true,
            Score=20},
        new UserFlag(){
            Id=new Guid(""),
            User=UserController.Users[1],
            Flag=FlagController.Flags[1],
            Active= true,
            Score=50},
    };

    private readonly ILogger<UserFlagController> _logger;

    public UserFlagController(ILogger<UserFlagController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUserFlags")]
    public IEnumerable<UserFlag> Get()
    {
        return UserFlags;
    }

    [HttpGet]
    [Route("/users/{userId}")]
    public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId)
    {
        return UserFlags.Where(x => x.User.Id == userId);
    }
    [HttpGet]
    [Route("/flags/{flagId}")]
    public IEnumerable<UserFlag> GetUsersPerFlag(Guid flagId)
    {
        return UserFlags.Where(x => x.Flag.Id == flagId);
    }

    // [HttpPost]
    // [Route("/new")]
    // public
}
