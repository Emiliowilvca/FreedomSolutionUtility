using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SaleFeesValidator : AbstractValidator<ISaleFees>
    {
        public SaleFeesValidator()
        {
            RuleFor(x => x.CustomerAccountId).Generic(1, int.MaxValue, Lang.CustomerAccountNumberIsInvalid, nameof(Lang.CustomerAccountNumberIsInvalid));

            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));

            RuleFor(x => x.MoneyId).Generic(1, int.MaxValue, Lang.moneyIsInvalid, nameof(Lang.moneyIsInvalid));

            RuleFor(x => x.PromissoryNote).Generic(0, int.MaxValue, Lang.PromissoryNoteIsInvalid, nameof(Lang.PromissoryNoteIsInvalid));

            RuleFor(x => x.NumberFees).Generic(0, byte.MaxValue, Lang.NumberOfInstallmentsInvalid, nameof(Lang.NumberOfInstallmentsInvalid));
        }
    }
}