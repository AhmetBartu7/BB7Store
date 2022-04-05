using AutoMapper;
using Entities.Concrete;
using Entities.DtoConcrete.DtoCategories;
using Entities.DtoConcrete.DtoCustomers;
using Entities.DtoConcrete.DtoOrderDetails;
using Entities.DtoConcrete.DtoOrders;
using Entities.DtoConcrete.DtoOrdersAddress;
using Entities.DtoConcrete.DtoProducts;
using Entities.DtoConcrete.DtoProductsImages;
using Entities.DtoConcrete.DtoTempBaskets;

namespace Business.AutoMappers
{
    public class AllProfile : Profile
    {
        public AllProfile()
        {
            #region Categories
            CreateMap<Categories, DtoCategories>();
            CreateMap<DtoCategories, Categories>();
            CreateMap<DtoCategoriesProducts, Categories>();
            #endregion

            #region Customers
            CreateMap<Customers, DtoCustomersCreate>();
            CreateMap<Customers, DtoCustomersUpdate>();
            CreateMap<DtoCustomersList, Customers>();
            #endregion

            #region Orders
            CreateMap<Orders, DtoOrdersCreate>();
            CreateMap<Orders, DtoOrdersUpdate>();
            CreateMap<DtoOrdersListMore, Orders>();
            CreateMap<DtoOrdersList, Orders>();
            #endregion

            #region OrderAddress
            CreateMap<OrdersAddress, DtoOrdersAddressCreate>();
            CreateMap<DtoOrdersAddressList, OrdersAddress>();
            #endregion

            #region OrderDetails
            CreateMap<OrderDetails, DtoOrderDetailsCreate>();
            CreateMap<DtoOrderDetailsList, OrderDetails>();
            #endregion


            #region ProductImages
            CreateMap<ProductsImages, DtoProductImagesCreate>();
            CreateMap<DtoProductImagesList, ProductsImages>();
            #endregion


            #region Products
            CreateMap<Products, DtoProductsCreate>();
            CreateMap<Products, DtoProductsUpdate>();
            CreateMap<DtoProductsList, Products>();
            CreateMap<DtoProductsListMore, Products>();

            #endregion


            #region TempBaskets
            CreateMap<TempBaskets, DtoTempBasketsCreate>();
            CreateMap<TempBaskets, DtoTempBasketsUpdate>();
            CreateMap<DtoTempBasketsList, TempBaskets>();

            #endregion
        }
    }
}
