using Core.Abstract;

namespace Entities.DtoConcrete.DtoProducts
{
    public class DtoProductsList : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }

    }
}
