using Core.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Products : BaseEntity,IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }
        public string Images { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Stock { get; set; }
        public IList<ProductsImages> ProductsImages { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }





    }
}
