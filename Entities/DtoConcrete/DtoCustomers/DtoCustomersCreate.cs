using Core.Abstract;

namespace Entities.DtoConcrete.DtoCustomers
{
    public class DtoCustomersCreate : IDto
    {
        public string NameSurName { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
