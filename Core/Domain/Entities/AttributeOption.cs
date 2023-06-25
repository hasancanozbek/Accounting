
using Domain.Common;

namespace Domain.Entities
{
    public class AttributeOption : BaseEntity
    {
        public string Code { get; set; }
        public string DisplayText { get; set; }
        public Attribute Attribute { get; set; }
        public List<VariantAttribute>? VariantAttributes { get; set; }

    }
}
