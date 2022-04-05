using Entities.DtoConcrete.DtoCustomers;
using FluentValidation;

namespace Business.FluentValidations
{
    public class CustomersCreateValidation : AbstractValidator<DtoCustomersCreate>
    {
        public CustomersCreateValidation()
        {
            RuleFor(x => x.NameSurName).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.NameSurName).MaximumLength(50).WithMessage(" Maximum 50 Karakter girebilirsiniz");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Password).MaximumLength(25).WithMessage(" Maximum 25 Karakter girebilirsiniz");

            RuleFor(x => x.Phone).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Phone).MaximumLength(15).WithMessage(" Maximum 15 Karakter girebilirsiniz");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage(" Lütfen Geçerli Bir Mail Giriniz");
        }
    }
}
