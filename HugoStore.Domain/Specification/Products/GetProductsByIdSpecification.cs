using System.Linq.Expressions;
using HugoStore.Domain.Abstractions;
using HugoStore.Domain.Entities;

namespace HugoStore.Domain.Specification.Products;

public class GetProductsByIdSpecification(Guid id) : Specification<Product>
{
    public override Expression<Func<Product, bool>> toExpression() 
        => product => product.Id == id;
}