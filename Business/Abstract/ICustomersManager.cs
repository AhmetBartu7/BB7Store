using Core.Results.Abstract;
using Entities.DtoConcrete.DtoCustomers;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomersManager
    {
        public Task<DtoCustomersList> Login(string Email, string Sifre);
        public Task<bool> ForgotPassword(string Email);
        public Task<bool> DataKontrol(string Email, string Phone);
        public Task<IDataResult<DtoCustomersList>> GetById(int Id);

        public Task<IResult> Add(DtoCustomersCreate data);
        public Task<IResult> Update(DtoCustomersUpdate data);
        public Task<IResult> Delete(int data);
    }
}
