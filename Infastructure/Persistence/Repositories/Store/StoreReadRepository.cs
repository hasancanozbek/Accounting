using Application.Abstractions.Repositories.Store;
using Persistence.Contexts;

namespace Persistence.Repositories.Store
{
    public class StoreReadRepository : ReadRepository<Domain.Entities.Store>, IStoreReadRepository
    {
        public StoreReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
