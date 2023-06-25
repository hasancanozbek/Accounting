using Application.Abstractions.Repositories.SaleMain;
using Persistence.Contexts;

namespace Persistence.Repositories.SaleMain
{
    public class SaleMainWriteRepository : WriteRepository<Domain.Entities.SaleMain>, ISaleMainWriteRepository
    {
        public SaleMainWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
