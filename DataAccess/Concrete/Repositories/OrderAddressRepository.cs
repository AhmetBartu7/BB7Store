using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Repositories
{
    public class OrdersAddressRepository : EntityRepository<OrdersAddress>, IOrdersAddressRepository
    {
        public OrdersAddressRepository(DbContext context) : base(context)
        {

        }

    }
}
