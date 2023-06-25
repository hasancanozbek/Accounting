
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Attribute = Domain.Entities.Attribute;

namespace Persistence.Contexts
{
    public class AccountingDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<SaleMain> MainSales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<VariantAttribute> VariantAttributes { get; set; }
        public DbSet<AttributeOption> AttributeOptions { get; set; }

        public AccountingDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedTime = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedTime = DateTime.Now,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
