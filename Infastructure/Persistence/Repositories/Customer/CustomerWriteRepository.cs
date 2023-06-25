using Application.Abstractions.Repositories.Customer;
using Persistence.Contexts;

namespace Persistence.Repositories.Customer
{
    public class CustomerWriteRepository : WriteRepository<Domain.Entities.Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
