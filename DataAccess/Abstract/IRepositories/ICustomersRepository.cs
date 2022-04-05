using Entities.Concrete;
using Entities.DtoConcrete.DtoCustomers;
using System.Threading.Tasks;

namespace DataAccess.Abstract.IRepositories
{
    public interface ICustomersRepository : IEntityRepository<Customers>
    {
        public Task<Customers> Login(string Email, string Sifre);
        public Task<bool> ForgotPassword(string Email);
        public Task<bool> DataKontrol(string Email, string Phone); // Aynı mail ve telefon ile kontrol olmiyacak
      
    }
}
