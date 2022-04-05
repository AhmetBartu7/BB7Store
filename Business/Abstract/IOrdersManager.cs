using Core.Results.Abstract;
using Entities.DtoConcrete.DtoOrderDetails;
using Entities.DtoConcrete.DtoOrders;
using Entities.DtoConcrete.DtoOrdersAddress;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrdersManager
    {
        public Task<IDataResult<DtoOrdersList>> GetAllOrders(int OrdersId);
        public Task<IDataResult<DtoOrdersListMore>> GetById(int OrdersId);
        public Task<IResult> Add(DtoOrdersCreate orderData, DtoOrdersAddressCreate orderAdress, DtoOrderDetailsCreate orderdetails);
        public Task<IResult> Delete(int Id);
        public Task<IResult> Update(int OrdersId, byte OrdersType);
    }
}
