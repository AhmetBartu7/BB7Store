using Entities.DtoConcrete.DtoOrdersAddress;
using FluentValidation;

namespace Business.FluentValidations
{
    public class OrdersAddressCreateValidation : AbstractValidator<DtoOrdersAddressCreate>
    {
        public OrdersAddressCreateValidation()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.City).MaximumLength(50).WithMessage(" Maximum 50 Karakter girebilirsiniz");

            RuleFor(x => x.District).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.District).MaximumLength(50).WithMessage(" Maximum 50 Karakter girebilirsiniz");

            RuleFor(x => x.FullAddress).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.FullAddress).MaximumLength(350).WithMessage(" Maximum 350 Karakter girebilirsiniz");
        }
    }
}
