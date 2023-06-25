using Application.Abstractions.Repositories.Address;
using Application.Abstractions.Repositories.Attribute;
using Application.Abstractions.Repositories.AttributeOption;
using Application.Abstractions.Repositories.Customer;
using Application.Abstractions.Repositories.Others;
using Application.Abstractions.Repositories.Product;
using Application.Abstractions.Repositories.SaleDetail;
using Application.Abstractions.Repositories.SaleMain;
using Application.Abstractions.Repositories.Store;
using Application.Abstractions.Repositories.Variant;
using Application.Abstractions.Repositories.VariantAttribute;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories.Address;
using Persistence.Repositories.Attribute;
using Persistence.Repositories.AttributeOption;
using Persistence.Repositories.Customer;
using Persistence.Repositories.Other;
using Persistence.Repositories.Product;
using Persistence.Repositories.SaleDetail;
using Persistence.Repositories.SaleMain;
using Persistence.Repositories.Store;
using Persistence.Repositories.Variant;
using Persistence.Repositories.VariantAttribute;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AccountingDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            
            services.AddScoped<IVariantReadRepository, VariantReadRepository>();
            services.AddScoped<IVariantWriteRepository, VariantWriteRepository>();

            services.AddScoped<IVariantAttributeReadRepository, VariantAttributeReadRepository>();
            services.AddScoped<IVariantAttributeWriteRepository, VariantAttributeWriteRepository>();

            services.AddScoped<IAttributeReadRepository, AttributeReadRepository>();
            services.AddScoped<IAttributeWriteRepository, AttributeWriteRepository>();

            services.AddScoped<IAttributeOptionReadRepository, AttributeOptionReadRepository>();
            services.AddScoped<IAttributeOptionWriteRepository, AttributeOptionWriteRepository>();

            services.AddScoped<IStoreReadRepository, StoreReadRepository>();
            services.AddScoped<IStoreWriteRepository, StoreWriteRepository>();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IAddressReadRepository, AddressReadRepository>();
            services.AddScoped<IAddressWriteRepository, AddressWriteRepository>();

            services.AddScoped<ISaleMainReadRepository, SaleMainReadRepository>();
            services.AddScoped<ISaleMainWriteRepository, SaleMainWriteRepository>();

            services.AddScoped<ISaleDetailReadRepository, SaleDetailReadRepository>();
            services.AddScoped<ISaleDetailWriteRepository, SaleDetailWriteRepository>();

            services.AddScoped<ICountryReadRepository, CountryReadRepository>();
            services.AddScoped<ICountryWriteRepository, CountryWriteRepository>();

            services.AddScoped<ICityReadRepository, CityReadRepository>();
            services.AddScoped<ICityWriteRepository, CityWriteRepository>();
        }
    }
}
