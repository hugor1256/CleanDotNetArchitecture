using System.Security.AccessControl;

namespace HugoStore.Domain.Abstractions;

public abstract class Entity
{
    public Guid Id { get; set; }
}