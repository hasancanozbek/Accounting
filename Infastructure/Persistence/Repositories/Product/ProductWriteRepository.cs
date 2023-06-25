using Application.Abstractions.Repositories.Product;
using Persistence.Contexts;

namespace Persistence.Repositories.Product
{
    public class ProductWriteRepository : WriteRepository<Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(AccountingDbContext context) : base(context)
        {
        }
    }
}
