using HugoStore.Domain.Abstractions;

namespace HugoStore.Domain.Entities;

public class Product : Entity
{
    public string Title { get; set; } = string.Empty;
}