using FirstApp;
using FirstApp.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
//var data = new Data();
app.MapGet("/fruit/all", () => Data.all);
app.MapGet("/fruit/{id}", (int id) => Data.all[id]);
app.MapPost("/friut/{id}", Command.CreateFruit);
app.MapPut("/fruit/{id}", Command.UpdateFruit);
app.MapDelete("/fruit/{id}", Command.DeleteFruit);
app.Run();
