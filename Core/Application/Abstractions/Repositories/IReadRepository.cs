
using Domain.Common;
using System.Linq.Expressions;

namespace Application.Abstractions.Repositories
{
    public interface IReadRepository<T> :IRepository<T> where T : BaseEntity, new()
    {
        Task<T> GetByIdAsync(int id, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        IQueryable<T> GetAll(bool tracking = false);
        IQueryable<T> GetWithExpression(Expression<Func<T, bool>> method, bool tracking = true);
    }
}
