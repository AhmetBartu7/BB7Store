using Core.Abstract;

namespace Entities.DtoConcrete.DtoProductsImages
{
    public class DtoProductImagesCreate : IDto
    {
        public string ImagesName { get; set; }
        public int ProductsId { get; set; }
    }
}
