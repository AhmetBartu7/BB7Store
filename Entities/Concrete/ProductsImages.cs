using Core.Abstract;

namespace Entities.Concrete
{
    public class ProductsImages : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public string ImagesName { get; set; }
        public int ProductsId { get; set; }
        public Products Products { get; set; }
    }
}
