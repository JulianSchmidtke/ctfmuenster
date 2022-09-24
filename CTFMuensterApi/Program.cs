#define MOCKDATABASE

using CTFMuensterApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#if MOCKDATABASE
    builder.Services.AddSingleton<IDataRepository, DummyData>();
#else
    builder.Services.AddSingleton<IDataRepository, EFData>();
    builder.Services.AddDbContext<ModelDbContext>(options => options.UseSqlite("Filename=jovel_flags.db"));
#endif
builder.Services.AddSingleton<IDataService, DataService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// make sure DB exists
#if !MOCKDATABASE
    var dbBuilder = new DbContextOptionsBuilder();
    dbBuilder.UseSqlite("Filename=jovel_flags.db");
    using (var db = new ModelDbContext(dbBuilder.Options))
    {
        db.Database.EnsureCreated();
        db.Database.Migrate();
    }
#endif

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors(x => {
    x.AllowAnyHeader();
    x.AllowAnyMethod(); 
    x.AllowAnyOrigin();
    });

app.Run();
