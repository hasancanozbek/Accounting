using Application.Abstractions.Repositories.Attribute;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence.Repositories.Attribute
{
    public class AttributeWriteRepository : WriteRepository<Domain.Entities.Attribute>, IAttributeWriteRepository
    {
        public AttributeWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}