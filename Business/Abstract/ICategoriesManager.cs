using Core.Results.Abstract;
using Entities.DtoConcrete.DtoCategories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoriesManager
    {
      
        public Task<IDataResult<IList<DtoCategories>>> GetAllCategories();
        public Task<IDataResult<DtoCategories>> GetById(int Id);
        

        public Task<IResult> Add(DtoCategories data);
        public Task<IResult> Update(DtoCategories data);
        public Task<IResult> Delete(int data);
        
    }
}
