
using Domain.Common;

namespace Domain.Entities
{
    public class SaleMain : BaseEntity
    {
        public Store Store { get; set; }
        public Decimal TotalAmount { get; set; }
        public int TotalQuantity { get; set; }
        public List<SaleDetail>? SaleDetails { get; set; }
    }
}
