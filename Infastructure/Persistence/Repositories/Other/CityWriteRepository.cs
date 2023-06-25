
using Application.Abstractions.Repositories.Others;
using Persistence.Contexts;

namespace Persistence.Repositories.Other
{
    public class CityWriteRepository : WriteRepository<Domain.Entities.City>, ICityWriteRepository
    {
        public CityWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
