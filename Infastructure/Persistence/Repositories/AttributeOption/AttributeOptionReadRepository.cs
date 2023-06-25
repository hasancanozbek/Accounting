using Application.Abstractions.Repositories.AttributeOption;
using Persistence.Contexts;

namespace Persistence.Repositories.AttributeOption
{
    public class AttributeOptionReadRepository : ReadRepository<Domain.Entities.AttributeOption>, IAttributeOptionReadRepository
    {
        public AttributeOptionReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
