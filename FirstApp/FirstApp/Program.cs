using FirstApp;
using FirstApp.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
//var data = new Data();
app.MapGet("/task/all", () => Data.all);
app.MapGet("/task/{id}", (int id) => Data.all[id]);
app.MapPost("/task/{id}", Command.CreateTask);
app.MapPut("/task/{id}", Command.UpdateTask);
app.MapDelete("/task/{id}", Command.DeleteTask);
app.Run();
