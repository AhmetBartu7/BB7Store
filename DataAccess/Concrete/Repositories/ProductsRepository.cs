using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class ProductsRepository : EntityRepository<Products>, IProductsRepository
    {
        public ProductsRepository(DbContext context): base(context) 
        {

        }

        public async Task<IList<Products>> MultiProducts()
        {
            return await GetAllData(); 
        }

        public async Task<IList<Products>> MultiProductsImages()
        {
            return await GetAllData(null, x => x.ProductsImages);
        }

        public async Task<Products> SingleProducts(int Id)
        {
            return await GetById(Id);
        }

        public async Task<Products> SingleProductsImages(int Id)
        {
            return GetAllData(c => c.Id == Id, x => x.ProductsImages).Result.FirstOrDefault();
        }
    }
}
