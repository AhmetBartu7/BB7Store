using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class TempBasketsRepository : EntityRepository<TempBaskets>, ITempBasketsRepository
    {
        public TempBasketsRepository(DbContext context) : base(context)
        {

        }
        public async Task<bool> NullControl(int Id, int CookiesId)
        {
            return await VarmiYokmi(x => x.ProductsId == Id && x.CookiesId == CookiesId);
        }

        public async Task<TempBaskets> PieceSetting(int Id, int CookiesId, bool Type)
        {
            var data = GetAllData(x => x.Id == Id && x.CookiesId == CookiesId).Result.FirstOrDefault();

            if (Type)
            {
                data.Piece++;
            }
            else
            {
                if (data.Piece > 1)
                {
                    data.Piece--;
                }
            }
            return data;
        }
    }
}
