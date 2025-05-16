using HugoStore.Application;
using HugoStore.Domain.Repositories;
using HugoStore.Infrastructure;
using HugoStore.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(s =>
{
    s.UseSqlServer(connectionString, b => b.MigrationsAssembly("HugoStore.Api"));
});

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("v1/products/{id}", async (
        ISender sender,
        Guid id,
        CancellationToken cancellationToken)
    =>
{
    var command = new HugoStore.Application.UseCases.Products.GetById.Command(id);
    var result = await sender.Send(command, cancellationToken);

    return result.IsSuccess ? Results.Ok(result.Value) : Results.BadRequest(result.Error);
});

app.Run();