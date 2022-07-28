using Microsoft.EntityFrameworkCore;
using CommandAPI.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services and dependancies
builder.Services.AddControllers();
builder.Services.AddDbContext<CommandContext>(o=>o.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection")));
builder.Services.AddScoped<ICommandAPIRepo,SqlCommandAPIRepo>();
var app = builder.Build();

// Add middlewares
app.MapControllers();
app.Run();
