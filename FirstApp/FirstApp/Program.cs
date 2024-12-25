using FirstApp;
using LifeTime; 

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<Context>();
builder.Services.AddTransient<Repository>();

var app = builder.Build();

app.MapGet("/", GetString);

app.Run();

static string GetString(Context context, Repository repository) 
	=> $"context: { context.DataRow}, repository:{ repository.DataRow }";