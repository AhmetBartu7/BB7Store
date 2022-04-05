using DataAccess.Abstract.IRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class CustomersRepository : EntityRepository<Customers>, ICustomersRepository
    {
        public CustomersRepository(DbContext context) : base(context)
        {

        }
        public async Task<bool> DataKontrol(string Email, string Phone)
        {
            return await VarmiYokmi(x => x.Email == Email && x.Phone == Phone);
        }

        public async Task<bool> ForgotPassword(string Email)
        {
            return await VarmiYokmi(x => x.Email == Email);
        }

        public async Task<Customers> Login(string Email, string Sifre)
        {
            return await Task.Run(() => GetAllData(x => x.Email == Email && x.Password == Sifre).Result.FirstOrDefault());
          
        }

    
    }
}
