using Core.Abstract;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Orders : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public int CustomersId { get; set; }
        public long CargoNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        public decimal CargoPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DicountPrice { get; set; }
        public decimal KDV { get; set; }
        public byte OrderStatus { get; set; }
        public byte OrderType { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Customers Customers { get; set; }
        public ICollection<OrdersAddress> OrdersAddress { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}

