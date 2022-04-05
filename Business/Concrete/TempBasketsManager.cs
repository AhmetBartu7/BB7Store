using AutoMapper;
using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.UnitOfWorks;
using Entities.Concrete;
using Entities.DtoConcrete.DtoTempBaskets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TempBasketsManager : ITempBasketsManager
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly IMapper mapper;

        public TempBasketsManager(IUnitOfWorks _unitOfWorks, IMapper _mapper)
        {
            unitOfWorks = _unitOfWorks;
            mapper = _mapper;
        }
        public async Task<IResult> Add(DtoTempBasketsCreate data)
        {
            return await unitOfWorks.TempBasketsRepo.AsyncAdd(mapper.Map<TempBaskets>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IResult> Delete(int data)
        {
            return await unitOfWorks.TempBasketsRepo.AsyncDelete(data).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<bool> NullControl(int Id, int CookiesId)
        {
            
            return await unitOfWorks.TempBasketsRepo.NullControl(Id,CookiesId);
        }

        public async Task<IDataResult<DtoTempBasketsList>> PieceSetting(int Id, int CookiesId, bool Type)
        {
            var data = mapper.Map<DtoTempBasketsList>(unitOfWorks.TempBasketsRepo.PieceSetting(Id,CookiesId,Type));
            return new DataResult<DtoTempBasketsList>("Listeleme Başarılı", 0, data);
        }

        public async Task<IResult> Update(DtoTempBasketsUpdate data)
        {
            return await unitOfWorks.TempBasketsRepo.AsyncUpdate(mapper.Map<TempBaskets>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }
    }
}
