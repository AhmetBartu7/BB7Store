using Entities.DtoConcrete.DtoOrderDetails;
using FluentValidation;

namespace Business.FluentValidations
{
    public class OrderDetailsCreateValidation : AbstractValidator<DtoOrderDetailsCreate>
    {
        public OrderDetailsCreateValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage(" Maximum 50 Karakter girebilirsiniz");

            RuleFor(x => x.Images).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Images).MaximumLength(50).WithMessage(" Maximum 50 Karakter girebilirsiniz");

            RuleFor(x => x.Piece).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Discount).NotEmpty().WithMessage("Boş Bırakılmaz");
        }
    }
}
