using AutoMapper;
using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.UnitOfWorks;
using Entities.Concrete;
using Entities.DtoConcrete.DtoProducts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductsManager : IProductsManager
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly IMapper mapper;

        public ProductsManager(IUnitOfWorks _unitOfWorks, IMapper _mapper)
        {
            unitOfWorks = _unitOfWorks;
            mapper = _mapper;
        }

        public async Task<IResult> Add(DtoProductsCreate data)
        {
            return await unitOfWorks.ProductsRepo.AsyncAdd(mapper.Map<Products>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IResult> Delete(int data)
        {
            return await unitOfWorks.ProductsRepo.AsyncDelete(data).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IDataResult<IList<DtoProductsList>>> GetAllProducts()
        {
            var data = mapper.Map<IList<DtoProductsList>>(unitOfWorks.ProductsRepo.GetAllData().Result);
            return new DataResult<IList<DtoProductsList>>("Listeleme Başarılı", 0, data);
        }


        public async Task<IDataResult<DtoProductsList>> GetById(int Id)
        {
            var data = mapper.Map<DtoProductsList>(unitOfWorks.ProductsRepo.GetById(Id));
            return new DataResult<DtoProductsList>("Listeleme Başarılı", 0, data);
        }


        public async Task<IResult> Update(DtoProductsUpdate data)
        {
            return await unitOfWorks.ProductsRepo.AsyncUpdate(mapper.Map<Products>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }
    }
}
