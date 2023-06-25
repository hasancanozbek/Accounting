
using Domain.Common;

namespace Domain.Entities
{
    public class VariantAttribute : BaseEntity
    {
        public int ProductId { get; set; }
        public int VariantId { get; set; }
        public int AttributeId { get; set; }
        public int AttributeOptionId { get; set; }
        public Product Product { get; set; }
        public Variant Variant { get; set; }
        public Attribute Attribute { get; set; }
        public AttributeOption AttributeOption { get; set; }
    }
}
