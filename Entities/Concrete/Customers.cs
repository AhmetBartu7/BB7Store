using Core.Abstract;

namespace Entities.Concrete
{
    public class Customers : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string NameSurName { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Disctrict { get; set; }
        public string FullAddress { get; set; }
        public Orders Orders { get; set; }
    }
}
