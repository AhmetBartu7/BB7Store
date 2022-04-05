using Core.Abstract;

namespace Entities.DtoConcrete.DtoProductsImages
{
    public class DtoProductImagesList : IDto
    {
        public int Id { get; set; }
        public string ImagesName { get; set; }
        public int ProductsId { get; set; }
    }
}
