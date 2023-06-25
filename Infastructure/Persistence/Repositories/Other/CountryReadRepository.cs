using Application.Abstractions.Repositories.Others;
using Persistence.Contexts;

namespace Persistence.Repositories.Other
{
    public class CountryReadRepository : ReadRepository<Domain.Entities.Country>, ICountryReadRepository
    {
        public CountryReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
