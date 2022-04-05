using Core.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Entities.DtoConcrete.DtoProducts
{
    public class DtoProductsListMore : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public string Images { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public ICollection<ProductsImages> ProductImages { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
