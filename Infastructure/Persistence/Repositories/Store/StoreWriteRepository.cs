using Application.Abstractions.Repositories.Store;
using Persistence.Contexts;

namespace Persistence.Repositories.Store
{
    public class StoreWriteRepository : WriteRepository<Domain.Entities.Store>, IStoreWriteRepository
    {
        public StoreWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
