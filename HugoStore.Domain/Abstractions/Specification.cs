using System.Linq.Expressions;

namespace HugoStore.Domain.Abstractions;

public abstract class Specification<T> : ISpecification<T>
{
    public abstract Expression<Func<T, bool>> toExpression();

    public bool IsSatisfiedBy(T entity)
    {
        var predicate = toExpression().Compile();
        return predicate(entity);
    }
}