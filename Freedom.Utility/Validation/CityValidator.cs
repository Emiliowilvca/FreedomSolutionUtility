using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Validation
{
    public class CityValidator : AbstractValidator<ICity>
    {
        public CityValidator()
        {
            RuleFor(x => x.Name).NotNull()
                                    .WithMessage(Langs.Lang.FieldNameIsNotValid)
                                    .WithErrorCode(nameof(Lang.FieldNameIsNotValid))
                                .Length(1, 50)
                                    .WithMessage(Langs.Lang.FieldNameIsNotValid)
                                    .WithErrorCode(nameof(Lang.FieldNameIsNotValid));

            RuleFor(x => x.StateId).NotNull()
                                        .WithMessage(Langs.Lang.State_ErrorMustSelect)
                                        .WithErrorCode(nameof(Lang.State_ErrorMustSelect))
                                   .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.State_ErrorMustSelect))
                                        .WithMessage(Langs.Lang.State_ErrorMustSelect);

            RuleFor(x => x.CompanyId).NotNull()
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                        .WithMessage(Langs.Lang.Company_ErrorMustSelect)
                                     .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                        .WithMessage(Langs.Lang.Company_ErrorMustSelect);
        }
    }
}