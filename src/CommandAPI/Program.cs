using Microsoft.EntityFrameworkCore;
using CommandAPI.Data;
using Npgsql;
using AutoMapper;
using Newtonsoft.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);

// Add services and dependancies
builder.Services.AddControllers().AddNewtonsoftJson(s =>
{
    s.SerializerSettings.ContractResolver = new
    CamelCasePropertyNamesContractResolver();
});
var connectionBuilder = new NpgsqlConnectionStringBuilder();
connectionBuilder.ConnectionString = builder.Configuration.GetConnectionString("PostgreSqlConnection");
connectionBuilder.Password = builder.Configuration["Password"];
connectionBuilder.Username = builder.Configuration["UserID"];
builder.Services.AddDbContext<CommandContext>(o => o.UseNpgsql(connectionBuilder.ConnectionString));
builder.Services.AddScoped<ICommandAPIRepo, SqlCommandAPIRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Add middlewares
app.MapControllers();
app.Run();
