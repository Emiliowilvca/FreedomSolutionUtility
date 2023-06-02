using FluentValidation;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class PurchaseInstallmentValidator : AbstractValidator<IPurchaseInstallment>
    {
        public PurchaseInstallmentValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.PurchaseId).Generic(0, int.MaxValue, "PurchaseId is invalid", "");

            RuleFor(x => x.FeeIndex).Generic(0, byte.MaxValue, "Installment index is invalid", "");

            RuleFor(x => x.ProviderId).ProviderID();

            RuleFor(x => x.Capital).Generic(0, decimal.MaxValue, "capital is invalid", "");

            RuleFor(x => x.Interest).Generic(0, decimal.MaxValue, "Interest is invalid", "");

            RuleFor(x => x.Feesvalue).Generic(0, decimal.MaxValue, "FeesValue is invalid", "");

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.Status).Status();

            RuleFor(x => x.Expirate).Generic("Expirate is invalid", "");

            RuleFor(x => x.Exchange).Exchange(0);
        }
    }
}