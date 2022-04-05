using Entities.Concrete;
using System.Threading.Tasks;

namespace DataAccess.Abstract.IRepositories
{
    public interface ITempBasketsRepository : IEntityRepository<TempBaskets>
    {
        public Task<TempBaskets> PieceSetting(int Id, int CookiesId, bool Type);
        public Task<bool> NullControl(int Id, int CookiesId);
    }
}
