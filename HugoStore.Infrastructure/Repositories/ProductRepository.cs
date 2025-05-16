using HugoStore.Domain.Entities;
using HugoStore.Domain.Repositories;
using HugoStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HugoStore.Infrastructure.Repositories;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    => await context.Products.FirstOrDefaultAsync(s=> s.Id == id, cancellationToken);
}