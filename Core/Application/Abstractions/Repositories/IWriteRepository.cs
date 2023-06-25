using Domain.Common;

namespace Application.Abstractions.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity, new() 
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        Task<bool> RemoveByIdAsync(int id);
        bool Update(T entity);
        Task<int> SaveAsync();
    }
}
