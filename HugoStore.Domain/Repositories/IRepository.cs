using HugoStore.Domain.Abstractions;

namespace HugoStore.Domain.Repositories;

public interface IRepository<T> where T : Entity;