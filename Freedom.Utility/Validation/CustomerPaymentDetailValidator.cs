using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class CustomerPaymentDetailValidator : AbstractValidator<ICustomerPaymentDetail>
    {
        public CustomerPaymentDetailValidator()
        {
            RuleFor(x => x.CustomerPaymentId).Generic(0, int.MaxValue, Lang.IdentityNumberIsNotValid, nameof(Lang.IdentityNumberIsNotValid));
            RuleFor(x => x.SaleId).Generic(1, int.MaxValue, Lang.SaleIdIsInvalid, nameof(Lang.SaleIdIsInvalid));
            RuleFor(x => x.SaleFeesId).Generic(1, int.MaxValue, Lang.SaleFeesIdIsInvalid, nameof(Lang.SaleFeesIdIsInvalid));
            RuleFor(x => x.NumberFees).Generic(0, byte.MaxValue, Lang.NumberOfInstallmentsInvalid, nameof(Lang.NumberOfInstallmentsInvalid));
            RuleFor(x => x.Interest).Generic(0, decimal.MaxValue, Lang.InterestIsInvalid, nameof(Lang.InterestIsInvalid));
            RuleFor(x => x.ValuePayment).Generic(0, decimal.MaxValue, Lang.PaymentValueIsInvalid, nameof(Lang.InterestIsInvalid));
            RuleFor(x => x.Exchange).Exchange(0);
        }
    }
}