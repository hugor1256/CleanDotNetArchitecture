using HugoStore.Domain.Entities;

namespace HugoStore.Domain.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}