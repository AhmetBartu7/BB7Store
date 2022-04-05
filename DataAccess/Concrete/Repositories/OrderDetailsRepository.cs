using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Repositories
{
    public class OrderDetailsRepository : EntityRepository<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(DbContext context) : base(context)
        {

        }
    }
}
