using FluentValidation;
using Freedom.Frontend.Models.Bindable;
using Freedom.Utility.Langs;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Frontend.BindableModelValidation
{
    /// <summary>
    /// BaknkDeposit Validator
    /// </summary>
    public class BankDepositBindValidator : AbstractValidator<BankDepositBind>
    {
        public BankDepositBindValidator()
        {
            RuleFor(x => x.TransactionDate).StringIsDateTime(Lang.TransactionDateIsInvalid, nameof(Lang.TransactionDateIsInvalid));

            RuleFor(x => x.DepositNumber).StringIsLong(1, long.MaxValue, Lang.DepositNumberIsInvalid, nameof(Lang.DepositNumberIsInvalid));

            RuleFor(x => x.TotalCash).StringIsDecimal(0, decimal.MaxValue, Lang.CashAmountIsInvalid, nameof(Lang.CashAmountIsInvalid));

            RuleFor(x => x.Concept).Generic(1, 50, Lang.ConceptIsInvalid, nameof(Lang.ConceptIsInvalid));

            RuleFor(x => x.DepositNumber).StringIsLong(1, long.MaxValue, Lang.DepositNumberIsInvalid, nameof(Lang.DepositNumberIsInvalid));

            RuleFor(x => x.BankName).Generic(1, 50, Lang.BankNameIsInvalid, nameof(Lang.BankNameIsInvalid));
        }
    }
}