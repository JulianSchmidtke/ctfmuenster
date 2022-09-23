using CTFMuenster.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace CTFMuensterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public static readonly User[] Users = new[]
    {
        new User(){
            Id=new Guid("e59871b2-5970-4f04-b1cd-42a0796a5279"), 
            UserName="Annabelle"},
        new User(){
            Id=new Guid("62abdae3-6942-4460-9d47-06cb953de8fb"), 
            UserName="Bertha"},
        new User(){
            Id=new Guid("90f2b715-b434-4362-b845-15397fa0a1dc"), 
            UserName="Christian"},
    };

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<User> Get()
    {
        return Users;
    }

    [HttpGet]
    [Route("{id}")]
    public User GetUser(Guid id)
    {
        return Users.Where(x => x.Id == id).First();
    }
}
