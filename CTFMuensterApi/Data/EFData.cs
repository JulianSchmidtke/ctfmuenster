using CTFMuenster.Api.Model;
using CTFMuensterApi.Data;
using Microsoft.EntityFrameworkCore;

public class EFData : IDataRepository
{
    private readonly IServiceScopeFactory _scopeFactory;

    public EFData(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public IEnumerable<Flag> GetFlags()
    {
        using (var scope = _scopeFactory.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ModelDbContext>();

            return db.Flags.ToArray();
            // when we exit the using block,
            // the IServiceScope will dispose itself 
            // and dispose all of the services that it resolved.
        }
    }

    public IEnumerable<UserFlag> GetUserFlags()
    {
        using (var scope = _scopeFactory.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ModelDbContext>();

            return db.UserFlags.ToArray();
            // when we exit the using block,
            // the IServiceScope will dispose itself 
            // and dispose all of the services that it resolved.
        }

    }

    public IEnumerable<User> GetUsers()
    {
        using (var scope = _scopeFactory.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ModelDbContext>();

            return db.Users.ToArray();
            // when we exit the using block,
            // the IServiceScope will dispose itself 
            // and dispose all of the services that it resolved.
        }

    }

    public Flag AddFlag(Flag flag)
    {
        using (var scope = _scopeFactory.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ModelDbContext>();

            var r_flag = db.Flags.Add(flag).Entity;
            db.SaveChanges();
            return r_flag;
            // when we exit the using block,
            // the IServiceScope will dispose itself 
            // and dispose all of the services that it resolved.
        }

    }

    public UserFlag AddUserFlag(UserFlag userFlag)
    {
        using (var scope = _scopeFactory.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ModelDbContext>();

            var r_userFlag = db.UserFlags.Add(userFlag).Entity;
            db.SaveChanges();
            return r_userFlag;
            // when we exit the using block,
            // the IServiceScope will dispose itself 
            // and dispose all of the services that it resolved.
        }
    }
}
