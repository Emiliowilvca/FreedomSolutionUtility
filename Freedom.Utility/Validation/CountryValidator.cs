using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Utility.Validation
{
    public class CountryValidator : AbstractValidator<ICountry>
    {
        public CountryValidator()
        {
            RuleFor(x => x.Name).NotNull()
                                    .WithMessage(Lang.FieldNameIsNotValid)
                                    .WithErrorCode(nameof(Lang.FieldNameIsNotValid))
                                .Length(1, 50)
                                    .WithMessage(Lang.FieldNameIsNotValid)
                                    .WithErrorCode(nameof(Lang.FieldNameIsNotValid));

            RuleFor(x => x.CompanyId).NotNull()
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                        .WithMessage(Lang.Company_ErrorMustSelect)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                        .WithMessage(Lang.Company_ErrorMustSelect);
        }
    }
}