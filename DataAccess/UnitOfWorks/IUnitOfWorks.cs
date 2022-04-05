using Core.Results.Abstract;
using DataAccess.Abstract.IRepositories;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        public IProductsImagesRepository ProductsImagesRepo { get;  }
        public IProductsRepository ProductsRepo { get; }
        public ICategoriesRepository CategoriesRepo { get; }
        public ICustomersRepository CustomersRepo { get; }
        public IOrderDetailsRepository OrderDetailsRepo { get; }
        public IOrdersAddressRepository OrderAddressRepo { get; }
        public IOrdersRepository OrdersRepo { get; }
        public ITempBasketsRepository TempBasketsRepo { get; }
       

       public Task<IResult> SaveChanges();
    }
}
