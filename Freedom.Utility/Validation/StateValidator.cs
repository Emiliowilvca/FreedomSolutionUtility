using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Validation
{
    public class StateValidator : AbstractValidator<IState>
    {
        public StateValidator()
        {
            RuleFor(x => x.Name).NotNull()
                                    .WithErrorCode(nameof(Lang.FieldNameIsNotValid))
                                    .WithMessage(Lang.FieldNameIsNotValid)
                                .Length(1, 50)
                                    .WithErrorCode(nameof(Lang.FieldNameIsNotValid))
                                    .WithMessage(Langs.Lang.FieldNameIsNotValid);

            RuleFor(x => x.CountryId).NotNull()
                                        .WithErrorCode(nameof(Lang.Country_ErrorMustSelect))
                                        .WithMessage(Langs.Lang.Country_ErrorMustSelect)
                                    .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.Country_ErrorMustSelect))
                                        .WithMessage(Langs.Lang.Country_ErrorMustSelect);

            RuleFor(x => x.CompanyId).NotNull()
                                        .WithMessage(Langs.Lang.Company_ErrorMustSelect)
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                    .InclusiveBetween(1, int.MaxValue)
                                        .WithMessage(Langs.Lang.Company_ErrorMustSelect)
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect));
        }
    }
}