using Core.Abstract;
using Entities.DtoConcrete.DtoProducts;
using System.Collections.Generic;

namespace Entities.DtoConcrete.DtoCategories
{
    public class DtoCategoriesProducts : IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<DtoProductsList> Products { get; set; }
    }
}
