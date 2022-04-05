using Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Abstract.IRepositories
{
    public interface ICategoriesRepository : IEntityRepository<Categories>
    {
        public Task<List<Categories>> Siralama(bool Filtre);
        public Task<IList<Categories>> MultiCategories();
        public Task<IList<Categories>> MultiCategoriesProducts();
        
    }
}
