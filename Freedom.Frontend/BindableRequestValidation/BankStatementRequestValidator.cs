using FluentValidation;
using Freedom.Frontend.Models.BindableRequestModels;
using Freedom.Utility.Langs;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Frontend.BindableRequestValidation
{
    public class BankStatementRequestValidator : AbstractValidator<BankStatementRequestBind>
    {
        public BankStatementRequestValidator()
        {
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.SinceDate).StringIsDateTime(Lang.DateSinceIsNotValid, nameof(Lang.DateSinceIsNotValid));

            RuleFor(x => x.UntilDate).StringIsDateTime(Lang.DateUntilIsNotValid, nameof(Lang.DateUntilIsNotValid));

            RuleFor(x => x.BankAccountId).Generic(1, int.MaxValue, Lang.BankAccountIsInvalid, nameof(Lang.BankAccountIsInvalid));

            RuleFor(x => x.OffSet).StringIsInteger(0, int.MaxValue, Lang.OffsetIsInvalid, nameof(Lang.OffsetIsInvalid));

            RuleFor(x => x.Limit).StringIsInteger(1, int.MaxValue, Lang.LimitIsInvalid, nameof(Lang.LimitIsInvalid));
        }
    }
}