using Core.Abstract;

namespace Entities.DtoConcrete.DtoCategories
{
  public  class DtoCategories : IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
