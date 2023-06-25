using Domain.Common;
namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public int Code { get; set; }
        public string CityName { get; set; }
        public Country Country { get; set; }
        public List<Address>? Addresses { get; set; }
    }
}
