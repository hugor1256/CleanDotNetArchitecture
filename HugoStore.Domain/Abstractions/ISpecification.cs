using System.Linq.Expressions;

namespace HugoStore.Domain.Abstractions;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> toExpression();
    bool IsSatisfiedBy(T entity);
}