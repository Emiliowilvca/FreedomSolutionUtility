using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request;

namespace Freedom.Utility.ValidationRequest
{
    public class XRequestValidator : AbstractValidator<XRequest>
    {
        public XRequestValidator()
        {
            RuleFor(x => x.Id).NotNull()
                                  .WithErrorCode(nameof(Lang.IdParameterOutOfRange))
                                  .WithMessage(Lang.IdParameterOutOfRange)
                              .InclusiveBetween(0, int.MaxValue)
                                  .WithErrorCode(nameof(Lang.IdParameterOutOfRange))
                                  .WithMessage(Lang.IdParameterOutOfRange);

            RuleFor(x => x.ItemsPerPage).NotNull()
                                             .WithErrorCode(nameof(Lang.PaginationItemsperPage))
                                             .WithMessage(Lang.PaginationItemsperPage)
                                        .InclusiveBetween(1, int.MaxValue)
                                            .WithErrorCode(nameof(Lang.PaginationItemsperPage))
                                            .WithMessage(Langs.Lang.PaginationItemsperPage);
            RuleFor(x => x.CompanyId).NotNull()
                                             .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                             .WithMessage(Lang.Company_ErrorMustSelect)
                                .InclusiveBetween(1, int.MaxValue)
                                        .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                        .WithMessage(Lang.Company_ErrorMustSelect);
            RuleFor(x => x.Page).NotNull()
                                    .WithErrorCode(nameof(Lang.PaginationNumberInNotValid))
                                    .WithMessage(Lang.PaginationNumberInNotValid)
                                .InclusiveBetween(1, int.MaxValue)
                                       .WithErrorCode(nameof(Lang.PaginationNumberInNotValid))
                                       .WithMessage(Lang.PaginationNumberInNotValid);
        }
    }
}