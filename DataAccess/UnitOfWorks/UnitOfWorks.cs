using Core.Results.Abstract;
using Core.Results.Concrete;
using DataAccess.Abstract.IRepositories;
using DataAccess.Concrete;
using DataAccess.Concrete.Repositories;
using System;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorks
{
    public class UnitOfWorks : IUnitOfWorks
    {
        
        private CategoriesRepository RepoCategories;
        private CustomersRepository RepoCustomers;
        private OrdersAddressRepository RepoOrderAddress;
        private OrdersRepository RepoOrders;
        private OrderDetailsRepository RepoOrderDetails;
        private ProductsImagesRepository RepoProductsImages;
        private ProductsRepository RepoProducts;
        private TempBasketsRepository RepoTempBaskets;
        private  MyContext context;

       
        public UnitOfWorks(MyContext _context)
        {
            context = _context;
        }

        public IProductsImagesRepository ProductsImagesRepo => RepoProductsImages ?? new ProductsImagesRepository(context);
        public IProductsRepository ProductsRepo => RepoProducts ?? new ProductsRepository(context);

        public ICategoriesRepository CategoriesRepo => RepoCategories ?? new CategoriesRepository(context);

        public ICustomersRepository CustomersRepo => RepoCustomers ?? new CustomersRepository(context);

        public IOrderDetailsRepository OrderDetailsRepo => RepoOrderDetails ?? new OrderDetailsRepository(context);

        public IOrdersAddressRepository OrderAddressRepo => RepoOrderAddress ?? new OrdersAddressRepository(context);

        public IOrdersRepository OrdersRepo => RepoOrders ?? new OrdersRepository(context);

        public ITempBasketsRepository TempBasketsRepo => RepoTempBaskets ?? new TempBasketsRepository(context);



       

        public async Task<IResult> SaveChanges()
        {
            using (context.Database.BeginTransaction())
            {
                try
                {
                    context.SaveChanges();
                    context.Database.CommitTransaction();
                    return new Result("İşlem Başarılı", 202);
                }
                catch(Exception e)
                {
                    context.Database.RollbackTransaction();
                    return new Result("İşlem Başarısız", 204, e.Message);

                }
            }
        }
    }
}
