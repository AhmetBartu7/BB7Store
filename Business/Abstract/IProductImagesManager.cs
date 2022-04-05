using Core.Results.Abstract;
using Entities.DtoConcrete.DtoProductsImages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductsImagesManager
    {
        public Task<IResult> AddAsync(DtoProductImagesCreate data);
        public Task<IResult> DeleteAsync(int data);
        public Task<IDataResult<IList<DtoProductImagesList>>> GetAllProductsImage(int ProductsId);
    }
}
