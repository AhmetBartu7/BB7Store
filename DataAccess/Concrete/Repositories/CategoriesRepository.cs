using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class CategoriesRepository : EntityRepository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(DbContext context) : base(context)
        {

        }

      
        public async Task<IList<Categories>> MultiCategories()
        {
            return await GetAllData();
        }

        public async Task<IList<Categories>> MultiCategoriesProducts()
        {
            return await GetAllData(null, x => x.Products);
        }

        public async Task<List<Categories>> Siralama(bool Filtre)
        {
            if (Filtre)
            {
                return GetAllData().Result.OrderBy(x => x.CategoryName).ToList();
            }
            else
            {
                return GetAllData().Result.OrderByDescending(x => x.CategoryName).ToList();
            }
        }
    }
}
