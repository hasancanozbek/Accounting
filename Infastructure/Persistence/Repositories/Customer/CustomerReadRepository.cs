using Application.Abstractions.Repositories.Customer;
using Persistence.Contexts;

namespace Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<Domain.Entities.Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
