using HugoStore.Domain.Abstractions;
using HugoStore.Domain.Entities;

namespace HugoStore.Domain.Repositories;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetByIdAsync(Specification<Product> specification, CancellationToken cancellationToken = default);
}