using Core.Abstract;

namespace Entities.DtoConcrete.DtoOrdersAddress
{
    public class DtoOrdersAddressList : IDto
    {
        public byte AddressType { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string FullAddress { get; set; }


    }
}
