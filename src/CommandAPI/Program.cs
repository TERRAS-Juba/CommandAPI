using Microsoft.EntityFrameworkCore;
using CommandAPI.Data;
using Npgsql;
var builder = WebApplication.CreateBuilder(args);

// Add services and dependancies
builder.Services.AddControllers();
var connectionBuilder=new NpgsqlConnectionStringBuilder();
connectionBuilder.ConnectionString=builder.Configuration.GetConnectionString("PostgreSqlConnection");
connectionBuilder.Password=builder.Configuration["Password"];
connectionBuilder.Username=builder.Configuration["UserID"];
builder.Services.AddDbContext<CommandContext>(o=>o.UseNpgsql(connectionBuilder.ConnectionString));
builder.Services.AddScoped<ICommandAPIRepo,SqlCommandAPIRepo>();
var app = builder.Build();

// Add middlewares
app.MapControllers();
app.Run();
