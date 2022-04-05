using AutoMapper;
using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.UnitOfWorks;
using Entities.Concrete;
using Entities.DtoConcrete.DtoProductsImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductImagesManager : IProductsImagesManager
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly IMapper mapper;

        public ProductImagesManager(IUnitOfWorks _unitOfWorks, IMapper _mapper)
        {
            unitOfWorks = _unitOfWorks;
            mapper = _mapper;
        }
        public async Task<IResult> AddAsync(DtoProductImagesCreate data)
        {
            return await unitOfWorks.ProductsImagesRepo.AsyncAdd(mapper.Map<ProductsImages>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IResult> DeleteAsync(int data)
        {
          
            return await unitOfWorks.ProductsImagesRepo.AsyncDelete(data).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IDataResult<IList<DtoProductImagesList>>> GetAllProductsImage(int ProductsId)
        {
            var data = mapper.Map<IList<DtoProductImagesList>>(unitOfWorks.ProductsRepo.GetAllData().Result);
            return new DataResult<IList<DtoProductImagesList>>("Listeleme Başarılı", 0, data);
        }

      
    }
}
