using Application.Abstractions.Repositories.Variant;
using Persistence.Contexts;

namespace Persistence.Repositories.Variant
{
    public class VariantWriteRepository : WriteRepository<Domain.Entities.Variant>, IVariantWriteRepository
    {
        public VariantWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
