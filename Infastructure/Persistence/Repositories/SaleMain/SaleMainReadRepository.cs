using Application.Abstractions.Repositories.SaleMain;
using Persistence.Contexts;

namespace Persistence.Repositories.SaleMain
{
    public class SaleMainReadRepository : ReadRepository<Domain.Entities.SaleMain>, ISaleMainReadRepository
    {
        public SaleMainReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
