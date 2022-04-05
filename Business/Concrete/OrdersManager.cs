using AutoMapper;
using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.UnitOfWorks;
using Entities.Concrete;
using Entities.DtoConcrete.DtoOrderDetails;
using Entities.DtoConcrete.DtoOrders;
using Entities.DtoConcrete.DtoOrdersAddress;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrdersManager : IOrdersManager
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly IMapper mapper;

        public OrdersManager(IUnitOfWorks _unitOfWorks, IMapper _mapper)
        {
            unitOfWorks = _unitOfWorks;
            mapper = _mapper;
        }
        public async Task<IResult> Add(DtoOrdersCreate orderData, DtoOrdersAddressCreate orderAdress, DtoOrderDetailsCreate orderdetails)
        {
            return await unitOfWorks.OrdersRepo.AsyncAdd(mapper.Map<Orders>(orderData))
                .ContinueWith(x => unitOfWorks.OrderDetailsRepo.AsyncAdd(mapper.Map<OrderDetails>(orderdetails)))
                .ContinueWith(x => unitOfWorks.OrderAddressRepo.AsyncAdd(mapper.Map<OrdersAddress>(orderAdress)))
                .ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IResult> Delete(int Id)
        {
            return await unitOfWorks.OrdersRepo.AsyncDelete(Id).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<IDataResult<DtoOrdersList>> GetAllOrders(int OrdersId)
        {
            var data = mapper.Map<DtoOrdersList>(unitOfWorks.OrdersRepo.GetById(OrdersId));
            return new DataResult<DtoOrdersList>("Listeleme Başarılı", 0, data);
        }

        public async Task<IDataResult<DtoOrdersListMore>> GetById(int OrdersId)
        {
            var data = mapper.Map<DtoOrdersListMore>(unitOfWorks.OrdersRepo.GetById(OrdersId,x=> x.OrdersAddress,x=> x.OrderDetails,x=>x.Customers));
            return new DataResult<DtoOrdersListMore>("Listeleme Başarılı", 0, data);
        }

        public async Task<IResult> Update(int OrdersId, byte OrdersType)
        {
            return await unitOfWorks.OrdersRepo.AsyncUpdate(mapper.Map<Orders>(OrdersId)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }
    }
}
