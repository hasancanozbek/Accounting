
using Application.Abstractions.Repositories.SaleDetail;
using Persistence.Contexts;

namespace Persistence.Repositories.SaleDetail
{
    public class SaleDetailReadRepository : ReadRepository<Domain.Entities.SaleDetail>, ISaleDetailReadRepository
    {
        public SaleDetailReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
