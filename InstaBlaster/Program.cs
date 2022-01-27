using InstaBlaster.Infrastructure.Implementations.Extensions;
using InstaBlaster.UseCases.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.RegisterInfrastructure();
builder.Services.RegisterUseCases();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
