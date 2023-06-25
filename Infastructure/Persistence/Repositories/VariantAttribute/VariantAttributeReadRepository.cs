using Application.Abstractions.Repositories.VariantAttribute;
using Persistence.Contexts;

namespace Persistence.Repositories.VariantAttribute
{
    public class VariantAttributeReadRepository : ReadRepository<Domain.Entities.VariantAttribute>, IVariantAttributeReadRepository
    {
        public VariantAttributeReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
