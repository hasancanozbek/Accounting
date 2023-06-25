using Domain.Common;

namespace Domain.Entities
{
    public class Address : BaseEntity
    {
        public Country Country { get; set; }
        public City City { get; set; }
        public string Details { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
