
using Application.Abstractions.Repositories.Address;
using Persistence.Contexts;

namespace Persistence.Repositories.Address
{
    public class AddressReadRepository : ReadRepository<Domain.Entities.Address>, IAddressReadRepository
    {
        public AddressReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
