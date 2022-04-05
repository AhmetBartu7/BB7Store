using Business.Abstract;
using Business.Concrete;
using Business.FluentValidations;
using DataAccess.Concrete;
using DataAccess.UnitOfWorks;
using Entities.DtoConcrete.DtoCategories;
using Entities.DtoConcrete.DtoCustomers;
using Entities.DtoConcrete.DtoOrderDetails;
using Entities.DtoConcrete.DtoOrdersAddress;
using Entities.DtoConcrete.DtoProducts;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Extensions
{
    public static class MyExtension 
    {
        public static IServiceCollection Turetme(this IServiceCollection service)
        {
            service.AddDbContext<MyContext>();
            service.AddScoped<IProductsManager, ProductsManager>();
            service.AddScoped<ICategoriesManager, CategoriesManager>();
            service.AddScoped<ICustomersManager, CustomersManager>();
            
            service.AddScoped<IUnitOfWorks, UnitOfWorks>();

            service.AddSingleton<IValidator<DtoCategories>,CategoriesValidation>();
            service.AddSingleton<IValidator<DtoCustomersCreate>, CustomersCreateValidation>();
            service.AddSingleton<IValidator<DtoCustomersUpdate>, CustomersUpdateValidation>();
            service.AddSingleton<IValidator<DtoOrderDetailsCreate>, OrderDetailsCreateValidation>();
            service.AddSingleton<IValidator<DtoOrdersAddressCreate>, OrdersAddressCreateValidation>();
            service.AddSingleton<IValidator<DtoProductsCreate>, ProductsCreateValidation>();
            service.AddSingleton<IValidator<DtoProductsUpdate>, ProductsUpdateValidation>();

             





            return service;
        }

    }
}
