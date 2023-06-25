using Application.Abstractions.Repositories.AttributeOption;
using Persistence.Contexts;

namespace Persistence.Repositories.AttributeOption
{
    public class AttributeOptionWriteRepository : WriteRepository<Domain.Entities.AttributeOption>, IAttributeOptionWriteRepository
    {
        public AttributeOptionWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
