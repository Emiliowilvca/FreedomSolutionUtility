using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class CustomerPaymentDocValidator : AbstractValidator<ICustomerPaymentDoc>
    {
        public CustomerPaymentDocValidator()
        {
            RuleFor(x => x.Id).ID();
            RuleFor(x => x.MoneyId).MoneyID();
            RuleFor(x => x.DocumentNum).Generic(1, 25, Lang.DocumentNumberIsInvalid, nameof(Lang.DocumentNumberIsInvalid));
            RuleFor(x => x.PaymentType).Generic(1, 25, Lang.PaymentTypeIsInvalid, nameof(Lang.PaymentTypeIsInvalid));
            RuleFor(x => x.Bank).Generic(1, 30, Lang.BankIdIsInvalid, nameof(Lang.BankIdIsInvalid));
            RuleFor(x => x.DateRelease).Generic(Lang.DateIsInvalid, nameof(Lang.DateIsInvalid));
            RuleFor(x => x.DateExpiration).Generic(Lang.ExpireDateIsInvalid, nameof(Lang.ExpireDateIsInvalid));
            RuleFor(x => x.AccountNum).Generic(1, 15, Lang.AccountNumberIsInvalid, nameof(Lang.AccountNumberIsInvalid));
            RuleFor(x => x.Exchange).Exchange(0);
            RuleFor(x => x.Sender).Generic(1, 30, Lang.SenderIsInvalid, nameof(Lang.SenderIsInvalid));
            RuleFor(x => x.DocumentValue).Generic(0, decimal.MaxValue, Lang.AmountIsInvalid, nameof(Lang.AmountIsInvalid));
        }
    }
}