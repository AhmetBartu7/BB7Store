using Core.Abstract;
using System;

namespace Entities.DtoConcrete.DtoOrders
{
    public class DtoOrdersCreate : IDto
    {
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        public decimal CargoPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DicountPrice { get; set; }
        public decimal KDV { get; set; }
        public byte OrderStatus { get; set; }
        public byte OrderType { get; set; }

    }
}
