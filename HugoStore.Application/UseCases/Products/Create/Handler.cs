﻿using HugoStore.Domain.Abstractions;
using HugoStore.Domain.Entities;
using HugoStore.Domain.Repositories;
using MediatR;

namespace HugoStore.Application.UseCases.Products.Create;

public class Handler(IProductRepository repository, IUnityOfWork unityOfWork) : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
        };

        await repository.CreateAsync(product, cancellationToken);
        await unityOfWork.CommitAsync();
        
        return Result.Success(new Response("Produto cadastrado com sucesso"));
    }
}