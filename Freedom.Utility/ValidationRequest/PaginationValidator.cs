using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request;

namespace Freedom.Utility.ValidationRequest
{
    public class PaginationValidator : AbstractValidator<Pagination>
    {
        public PaginationValidator()
        {
            RuleFor(x => x.ItemsPerPage).NotNull()
                                            .WithErrorCode(nameof(Lang.ItemsperPage))
                                            .WithMessage(Lang.PaginationItemsperPage)
                                        .InclusiveBetween(1, int.MaxValue)
                                            .WithErrorCode(nameof(Lang.PaginationItemsperPage))
                                            .WithMessage(Langs.Lang.PaginationItemsperPage);
            RuleFor(x => x.CompanyId).NotNull()
                                            .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                            .WithMessage(Lang.Company_ErrorMustSelect)
                                     .InclusiveBetween(1, int.MaxValue)
                                            .WithErrorCode(nameof(Lang.Company_ErrorMustSelect))
                                            .WithMessage(Langs.Lang.Company_ErrorMustSelect);
            RuleFor(x => x.Page).NotNull()
                                    .WithErrorCode(nameof(Lang.PaginationNumberInNotValid))
                                    .WithMessage(Langs.Lang.PaginationNumberInNotValid)
                                .InclusiveBetween(1, int.MaxValue)
                                    .WithErrorCode(nameof(Lang.PaginationNumberInNotValid))
                                    .WithMessage(Langs.Lang.PaginationNumberInNotValid);

            RuleFor(x => x.SearchId).NotNull()
                                            .WithErrorCode(nameof(Lang.IdIsInvalid))
                                            .WithMessage(Lang.IdIsInvalid)
                                     .InclusiveBetween(0, int.MaxValue)
                                            .WithErrorCode(nameof(Lang.IdIsInvalid))
                                            .WithMessage(Langs.Lang.IdIsInvalid);
        }
    }
}