using HugoStore.Domain.Abstractions;

namespace HugoStore.Infrastructure.Data;

public class UnityOfWork(AppDbContext context) : IUnityOfWork
{
    public async Task CommitAsync()
        => await context.SaveChangesAsync();
}