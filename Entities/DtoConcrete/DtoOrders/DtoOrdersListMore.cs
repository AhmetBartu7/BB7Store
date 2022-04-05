using Core.Abstract;
using Entities.DtoConcrete.DtoCustomers;
using Entities.DtoConcrete.DtoOrderDetails;
using Entities.DtoConcrete.DtoOrdersAddress;
using System;
using System.Collections.Generic;

namespace Entities.DtoConcrete.DtoOrders
{
    public class DtoOrdersListMore : IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public long CargoNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        public decimal CargoPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DicountPrice { get; set; }
        public decimal KDV { get; set; }
        public byte OrderStatus { get; set; }
        public byte OrderType { get; set; }
        public ICollection<DtoOrderDetailsList> OrderDetails { get; set; }
        public DtoCustomersList Customers { get; set; }
        public ICollection<DtoOrdersAddressList> DtoOrdersAddressList { get; set; }
    }
}
