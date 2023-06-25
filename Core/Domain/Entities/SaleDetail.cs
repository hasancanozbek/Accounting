
using Domain.Common;

namespace Domain.Entities
{
    public class SaleDetail : BaseEntity
    {
        public int SaleMainId { get; set; }
        public int VariantId { get; set; }
        public decimal SoldPrice { get; set; }
        public int Quantity { get; set; }

        public SaleMain SaleMain { get; set; }
        public Variant Variant { get; set; }

    }
}
