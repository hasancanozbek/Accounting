using Application.Abstractions.Repositories.VariantAttribute;
using Persistence.Contexts;

namespace Persistence.Repositories.VariantAttribute
{
    public class VariantAttributeWriteRepository : WriteRepository<Domain.Entities.VariantAttribute>, IVariantAttributeWriteRepository
    {
        public VariantAttributeWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
