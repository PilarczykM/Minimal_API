using MinimalApi;
using MinimalApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointDefinition(typeof(Customer));
var app = builder.Build();

app.UseEndpointDefinitions();

app.Run();
