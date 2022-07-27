var builder = WebApplication.CreateBuilder(args);

// Add services and dependancies
builder.Services.AddControllers();
var app = builder.Build();

// Add middlewares
app.MapControllers();
app.Run();
