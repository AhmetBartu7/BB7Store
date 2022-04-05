using Entities.DtoConcrete.DtoProducts;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.FluentValidations
{
    public class ProductsUpdateValidation : AbstractValidator<DtoProductsUpdate>
    {
        public ProductsUpdateValidation()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage(" Maximum 50 Karakter girebilirsiniz");

            RuleFor(x => x.Explanation).NotEmpty().WithMessage("Boş Bırakılmaz");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Discount).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.Stock).Must(NumberControl).WithMessage("Lütfen Tam Sayı Giriniz");
        }

        public bool NumberControl(int Data)
        {
            Regex regex = new Regex(@"^[0-9]{10}$");
            return regex.IsMatch(Data.ToString());
        }
    }
}
