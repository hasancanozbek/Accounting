using Domain.Common;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public string HashedPassword { get; set; }
        public List<Store>? Stores { get; set; }
    }
}
