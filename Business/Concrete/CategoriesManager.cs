using AutoMapper;
using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.UnitOfWorks;
using Entities.Concrete;
using Entities.DtoConcrete.DtoCategories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoriesManager : ICategoriesManager
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly IMapper mapper;
        
        public CategoriesManager(IUnitOfWorks _unitOfWorks, IMapper _mapper)
        {
            unitOfWorks = _unitOfWorks;
            mapper = _mapper;
        }
        
        public async Task<IResult> Add(DtoCategories data)
        {
            
               return await unitOfWorks.CategoriesRepo.AsyncAdd(mapper.Map<Categories>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IResult> Delete(int data)
        {
            return await unitOfWorks.CategoriesRepo.AsyncDelete(data).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IDataResult<IList<DtoCategories>>> GetAllCategories()
        {
            var data = mapper.Map<IList<DtoCategories>>(unitOfWorks.CategoriesRepo.GetAllData().Result);
            return new DataResult<IList<DtoCategories>>("Listeleme Başarılı", 0, data);
        }

        public async Task<IDataResult<DtoCategories>> GetById(int Id)
        {
            var data = mapper.Map<DtoCategories>(unitOfWorks.CategoriesRepo.GetById(Id));
            return new DataResult<DtoCategories>("Listeleme Başarılı", 0, data);
        }

        public async Task<IResult> Update(DtoCategories data)
        {
            return await unitOfWorks.CategoriesRepo.AsyncUpdate(mapper.Map<Categories>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }
    }
}
