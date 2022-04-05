using Core.Results.Abstract;
using Entities.DtoConcrete.DtoTempBaskets;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITempBasketsManager
    {
        public Task<IDataResult<DtoTempBasketsList>> PieceSetting(int Id, int CookiesId, bool Type);
        public Task<bool> NullControl(int Id, int CookiesId);

        public Task<IResult> Add(DtoTempBasketsCreate data);
        public Task<IResult> Update(DtoTempBasketsUpdate data);
        public Task<IResult> Delete(int data);
        
    }
}
