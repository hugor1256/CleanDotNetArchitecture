using HugoStore.Domain.Abstractions;
using HugoStore.Domain.Entities;
using HugoStore.Domain.Repositories;
using HugoStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HugoStore.Infrastructure.Repositories;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public async Task<Product?> GetByIdAsync(Specification<Product> specification, CancellationToken cancellationToken = default)
    => await context.Products.Where(specification.toExpression()).FirstOrDefaultAsync(cancellationToken);
}