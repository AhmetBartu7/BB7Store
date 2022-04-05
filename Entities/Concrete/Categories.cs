using Core.Abstract;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Categories : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
