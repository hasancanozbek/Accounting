
using Application.Abstractions.Repositories.SaleDetail;
using Persistence.Contexts;

namespace Persistence.Repositories.SaleDetail
{
    public class SaleDetailWriteRepository : WriteRepository<Domain.Entities.SaleDetail>, ISaleDetailWriteRepository
    {
        public SaleDetailWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
