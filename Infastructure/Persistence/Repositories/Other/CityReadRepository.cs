
using Application.Abstractions.Repositories.Others;
using Persistence.Contexts;

namespace Persistence.Repositories.Other
{
    public class CityReadRepository : ReadRepository<Domain.Entities.City>, ICityReadRepository
    {
        public CityReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
