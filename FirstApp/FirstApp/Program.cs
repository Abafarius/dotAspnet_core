using FirstApp;
using FirstApp.Model;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
//var data = new Data();
ICommand commandFruit = new CommandFruit();


app.MapGet("/fruit/all", () => Data.all);
app.MapGet("/fruit/{id}", (int id) => Data.all[id]);
app.MapPost("/friut/{id}", commandFruit.CreateFruit).WithParameterValidation();
app.MapPut("/fruit/{id}", commandFruit.UpdateFruit);
app.MapDelete("/fruit/{id}", commandFruit.DeleteFruit);
app.Run();
