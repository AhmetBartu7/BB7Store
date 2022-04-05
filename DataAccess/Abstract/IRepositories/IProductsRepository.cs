using Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract.IRepositories
{
    public interface IProductsRepository: IEntityRepository<Products>
    {
        public Task<Products> SingleProducts(int Id);
        public Task<IList<Products>> MultiProductsImages();
        public Task<IList<Products>> MultiProducts();
        public Task<Products> SingleProductsImages(int Id);
    }
}
