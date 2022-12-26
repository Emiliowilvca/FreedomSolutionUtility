using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Request.BankRequest;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.ValidationRequest
{
    public class RequestBankStatementValidator : AbstractValidator<BankStatementRequest>
    {
        public RequestBankStatementValidator()
        {
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.SinceDate).Generic(0, long.MaxValue, Lang.DateSinceIsNotValid, nameof(Lang.DateSinceIsNotValid));

            RuleFor(x => x.UntilDate).Generic(0, long.MaxValue, Lang.DateUntilIsNotValid, nameof(Lang.DateUntilIsNotValid));

            RuleFor(x => x.BankAccountId).Generic(1, int.MaxValue, Lang.BankAccountIsInvalid, nameof(Lang.BankAccountIsInvalid));

            RuleFor(x => x.OffSet).Generic(0, int.MaxValue, Lang.OffsetIsInvalid, nameof(Lang.OffsetIsInvalid));

            RuleFor(x => x.Limit).Generic(0, int.MaxValue, Lang.LimitIsInvalid, nameof(Lang.LimitIsInvalid));
        }
    }
}