using FluentValidation;
using Freedom.Frontend.Models.Bindable;
using Freedom.Utility.Langs;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Frontend.BindableModelValidation
{
    public class BankDepositDetailBindValidator : AbstractValidator<BankDepositDetailBind>
    {
        public BankDepositDetailBindValidator()
        {
            RuleFor(x => x.Amount).StringIsDecimal(0, decimal.MaxValue, Lang.AmountIsInvalid, nameof(Lang.AmountIsInvalid));

            RuleFor(x => x.CheckDate).StringIsDateTime(Lang.BankCheckDateIsInvalid, nameof(Lang.BankCheckDateIsInvalid));

            RuleFor(x => x.CheckNumber).StringIsLong(1, long.MaxValue, Lang.CheckNumberIsInvalid, nameof(Lang.CheckNumberIsInvalid));

            RuleFor(x => x.Sender).Generic(1, 50, Lang.SenderIsInvalid, nameof(Lang.SenderIsInvalid));

            RuleFor(x => x.Concept).Generic(1, 50, Lang.ConceptIsInvalid, nameof(Lang.ConceptIsInvalid));

            RuleFor(x => x.BankName).Generic(1, 50, Lang.BankNameIsInvalid, nameof(Lang.BankNameIsInvalid));
        }
    }
}