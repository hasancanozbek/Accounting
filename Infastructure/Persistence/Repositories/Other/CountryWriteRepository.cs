using Application.Abstractions.Repositories.Others;
using Persistence.Contexts;

namespace Persistence.Repositories.Other
{
    public class CountryWriteRepository : WriteRepository<Domain.Entities.Country>, ICountryWriteRepository
    {
        public CountryWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
