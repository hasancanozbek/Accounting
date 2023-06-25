
using Domain.Common;

namespace Domain.Entities
{
    public class Variant : BaseEntity
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public int Stock { get; set; }
        public Product Product { get; set; }
        public List<VariantAttribute>? VariantAttributes { get; set; }
        public List<SaleDetail>? SaleDetails { get; set; }
    }
}
