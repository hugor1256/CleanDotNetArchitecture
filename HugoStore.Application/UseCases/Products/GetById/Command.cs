using HugoStore.Domain.Abstractions;
using MediatR;

namespace HugoStore.Application.UseCases.Products.GetById;

public sealed record Command(Guid Id) : IRequest<Result<Response>>;