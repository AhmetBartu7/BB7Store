using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Repositories
{
    public class OrdersRepository : EntityRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        {

        }
    }
}
