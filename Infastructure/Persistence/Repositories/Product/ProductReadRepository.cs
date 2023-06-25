using Application.Abstractions.Repositories.Product;
using Persistence.Contexts;

namespace Persistence.Repositories.Product
{
    public class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
