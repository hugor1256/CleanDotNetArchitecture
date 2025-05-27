using HugoStore.Domain.Abstractions;
using HugoStore.Domain.Repositories;
using HugoStore.Domain.Specification.Products;
using MediatR;

namespace HugoStore.Application.UseCases.Products.GetById;

public sealed class Handler(IProductRepository repository) : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var spec = new GetProductsByIdSpecification(request.Id);
        var product = await repository.GetByIdAsync(spec, cancellationToken);
        
        return product is null 
            ? Result.Failure<Response>(new Error("404", "Product not found")) 
            : Result.Success(new Response(product.Id, product.Title));
    }
}