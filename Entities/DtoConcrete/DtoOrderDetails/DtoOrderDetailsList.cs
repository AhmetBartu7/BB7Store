using Core.Abstract;

namespace Entities.DtoConcrete.DtoOrderDetails
{
    public class DtoOrderDetailsList : IDto
    {
        public int Id { get; set; }
        public int OrdersId { get; set; }
        public int ProductsId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Images { get; set; }
        public int Piece { get; set; }
    }
}
