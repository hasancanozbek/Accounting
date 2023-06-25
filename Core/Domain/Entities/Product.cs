
using Domain.Common;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public Decimal? OldPrice { get; set; }
        public List<Variant> Variants { get; set; }
        public Store Store { get; set; }
        public List<VariantAttribute>? VariantAttributes { get; set; }
    }
}
