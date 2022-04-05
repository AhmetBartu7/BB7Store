using Core.Results.Abstract;
using Entities.DtoConcrete.DtoProducts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductsManager
    {
        public Task<IDataResult<DtoProductsList>> GetById(int Id);
        
        public Task<IDataResult<IList<DtoProductsList>>> GetAllProducts();
      
        public Task<IResult> Add(DtoProductsCreate data);
        public Task<IResult> Update(DtoProductsUpdate data);
        public Task<IResult> Delete(int data);


    }
}
