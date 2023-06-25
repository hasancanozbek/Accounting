using Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstractions.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table { get; }
    }
}
