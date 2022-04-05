using Core.Abstract;

namespace Entities.DtoConcrete.DtoOrdersAddress
{
    public class DtoOrdersAddressCreate : IDto
    {
        public byte AddressType { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string FullAddress { get; set; }
        public int OrdersId { get; set; }


    }
}
