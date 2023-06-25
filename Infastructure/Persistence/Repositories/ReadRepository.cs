
using Application.Abstractions.Repositories;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
    {
        private readonly AccountingDbContext context;

        public ReadRepository(AccountingDbContext context)
        {
            this.context = context;
        }

        public DbSet<T> Table => context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = false)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public IQueryable<T> GetWithExpression(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var query = Table.AsSingleQuery();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return await Table.FindAsync(id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(method);
        }

    }
}
