using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Repositories
{
    public class ProductsImagesRepository : EntityRepository<ProductsImages>, IProductsImagesRepository
    {
        public ProductsImagesRepository(DbContext context) : base(context) 
        {

        }
    }
}
