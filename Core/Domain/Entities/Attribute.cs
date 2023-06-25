
using Domain.Common;

namespace Domain.Entities
{
    public class Attribute : BaseEntity
    {
        public string DisplayName { get; set; }
        public List<AttributeOption>? AttributeOptions { get; set; }
        public List<VariantAttribute>? VariantAttributes { get; set; }
    }
}
