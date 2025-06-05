using HugoStore.Domain.Abstractions;
using MediatR;

namespace HugoStore.Application.UseCases.Products.Create;

public sealed record Command(string Title) : IRequest<Result<Response>>;