using Application.Abstractions.Repositories.Variant;
using Persistence.Contexts;

namespace Persistence.Repositories.Variant
{
    public class VariantReadRepository : ReadRepository<Domain.Entities.Variant>, IVariantReadRepository
    {
        public VariantReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
