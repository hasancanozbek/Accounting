using Domain.Common;

namespace Domain.Entities
{
    public class Store : BaseEntity
    {
        public string StoreName { get; set; }
        public Address Address { get; set; }
        public Customer Customer { get; set; }
        public List<SaleMain> SalesList { get; set; }
        public List<Product>? Products { get; set; }

    }
}
