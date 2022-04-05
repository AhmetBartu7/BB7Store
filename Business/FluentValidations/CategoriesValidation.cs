using Entities.DtoConcrete.DtoCategories;
using FluentValidation;


namespace Business.FluentValidations
{
    public class CategoriesValidation : AbstractValidator<DtoCategories>
    {

        public CategoriesValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş Bırakılmaz");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage(" Maximum 50 Karakter girebilirsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage(" Minimum 5 Karakter girebilirsiniz");
        }
    }
}
