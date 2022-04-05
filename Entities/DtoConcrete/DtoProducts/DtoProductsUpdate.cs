using Core.Abstract;

namespace Entities.DtoConcrete.DtoProducts
{
    public class DtoProductsUpdate : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string Images { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public int CategoriesId { get; set; }

    }
}
