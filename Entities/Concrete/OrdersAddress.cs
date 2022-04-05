using Core.Abstract;

namespace Entities.Concrete
{
    public class OrdersAddress : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public byte AddressType { get; set; }
        public byte City { get; set; }
        public string District { get; set; }
        public string FullAddress { get; set; }
        public int OrdersId { get; set; }
        public Orders Orders { get; set; }

    }
}
