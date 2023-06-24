using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SalePriceValidator : AbstractValidator<ISalePrice>
    {
        public SalePriceValidator()
        {
            RuleFor(x => x.ProductId).Generic(0, int.MaxValue, Lang.ProductIsInvalid, nameof(Lang.ProductIsInvalid));

            RuleFor(x => x.Level).Generic(1, 20, Lang.PriceLevelIsInvalid, nameof(Lang.PriceLevelIsInvalid));
            
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.ValuePrice).Generic(0, decimal.MaxValue, Lang.PriceValueIsInvalid, nameof(Lang.PriceValueIsInvalid));

            RuleFor(x => x.QuantityPrice).Generic(0, int.MaxValue, Lang.PriceAccordingToQuantityIsNotValid, nameof(Lang.PriceAccordingToQuantityIsNotValid));

            RuleFor(x => x.Installment).Generic(0, int.MaxValue, Lang.NumberOfInstallmentsInvalid, nameof(Lang.NumberOfInstallmentsInvalid));
        }
    }
}