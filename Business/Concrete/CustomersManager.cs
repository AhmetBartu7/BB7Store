using AutoMapper;
using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.ComplexType;
using Core.Results.Concrete;
using DataAccess.UnitOfWorks;
using Entities.Concrete;
using Entities.DtoConcrete.DtoCustomers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomersManager : ICustomersManager
    {
        private readonly IUnitOfWorks unitOfWorks;
        private readonly IMapper mapper;

        public CustomersManager(IUnitOfWorks _unitOfWorks, IMapper _mapper)
        {
            unitOfWorks = _unitOfWorks;
            mapper = _mapper;
        }
        public async Task<IResult> Add(DtoCustomersCreate data)
        {
            return await unitOfWorks.CustomersRepo.AsyncAdd(mapper.Map<Customers>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<bool> DataKontrol(string Email, string Phone)
        {
            return await unitOfWorks.CustomersRepo.DataKontrol(Email, Phone);
        }

        public async Task<IResult> Delete(int data)
        {
            return await unitOfWorks.CustomersRepo.AsyncDelete(data).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

        public async Task<bool> ForgotPassword(string Email)
        {
            return await unitOfWorks.CustomersRepo.ForgotPassword(Email);
        }

        public async Task<IDataResult<DtoCustomersList>> GetById(int Id)
        {
            var data = mapper.Map<DtoCustomersList>(unitOfWorks.CustomersRepo.GetById(Id));
            return new DataResult<DtoCustomersList>("Listeleme Başarılı", 0, data);
        }

        public async Task<DtoCustomersList> Login(string Email, string Sifre)
        {

            var bulunan = mapper.Map<DtoCustomersList>(unitOfWorks.CustomersRepo.GetAllData(x => x.Email == Email && x.Password == Sifre).Result.FirstOrDefault());
            return bulunan;

           
        }
        public async Task<IResult> Update(DtoCustomersUpdate data)
        {
            return await unitOfWorks.CustomersRepo.AsyncUpdate(mapper.Map<Customers>(data)).ContinueWith(x => unitOfWorks.SaveChanges()).Result;
        }

    }
}

