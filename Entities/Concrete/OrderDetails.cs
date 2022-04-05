using Core.Abstract;

namespace Entities.Concrete
{
    public class OrderDetails : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public int OrdersId { get; set; }
        public int ProductsId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Images { get; set; }
        public int Piece { get; set; }
        public Orders Orders { get; set; }
    }
}
