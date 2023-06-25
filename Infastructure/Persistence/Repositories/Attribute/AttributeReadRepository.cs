
using Application.Abstractions.Repositories.Attribute;
using Persistence.Contexts;

namespace Persistence.Repositories.Attribute
{
    public class AttributeReadRepository : ReadRepository<Domain.Entities.Attribute>, IAttributeReadRepository
    {
        public AttributeReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
