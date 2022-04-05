using Core.Abstract;
using System;

namespace Entities.DtoConcrete.DtoOrders
{
    public class DtoOrdersList : IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public byte OrderStatus { get; set; }
        public byte OrderType { get; set; }
    }
}
