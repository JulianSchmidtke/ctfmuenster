using CTFMuenster.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace CTFMuensterApi.Data
{

    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Flag> Flags { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserFlag> UserFlags { get; set; } = null!;
    }
}