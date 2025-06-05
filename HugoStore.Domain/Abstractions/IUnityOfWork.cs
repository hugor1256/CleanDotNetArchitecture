namespace HugoStore.Domain.Abstractions;

public interface IUnityOfWork
{
    Task CommitAsync();
}