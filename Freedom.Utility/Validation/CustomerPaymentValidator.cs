using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class CustomerPaymentValidator : AbstractValidator<ICustomerPayment>
    {
        public CustomerPaymentValidator()
        {
            RuleFor(x => x.Id).ID();
            RuleFor(x => x.CompanyId).CompanyID();
            RuleFor(x => x.DatePayment).PurchaseDate();
            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));
            RuleFor(x => x.CustomerAccountId).Generic(1, int.MaxValue, Lang.CustomerAccountNumberIsInvalid, nameof(Lang.CustomerAccountNumberIsInvalid));
            RuleFor(x => x.MoneyId).MoneyID();
            RuleFor(x => x.UserId).UserID();
            RuleFor(x => x.ShopId).ShopID();
            RuleFor(x => x.OperationTypeId).OperationTypeID();
            RuleFor(x => x.BoxId).BoxID();
            RuleFor(x => x.EmployeeId).EmployeeID();
            RuleFor(x => x.Concept).Generic(1, 150, Lang.ConceptIsInvalid, nameof(Lang.ConceptIsInvalid));
            RuleFor(x => x.PayValue).Generic(0, decimal.MaxValue, Lang.AmountIsInvalid, nameof(Lang.AmountIsInvalid));
            RuleFor(x => x.Interest).Generic(0, decimal.MaxValue, Lang.InterestRateMonthlyIsInvalid, nameof(Lang.InterestRateMonthlyIsInvalid));
            RuleFor(x => x.Exchange).Generic(0, decimal.MaxValue, Lang.ExchangeIsnotValid, nameof(Lang.ExchangeIsnotValid));
            RuleFor(x => x.Status).Generic(Lang.StatusIsInvalid, nameof(Lang.StatusIsInvalid));
        }
    }
}