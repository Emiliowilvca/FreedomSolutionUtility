using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SalePriceValidator : AbstractValidator<ISalePrice>
    {
        public SalePriceValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ProductId).Generic(0, int.MaxValue, Lang.ProductIsInvalid, nameof(Lang.ProductIsInvalid));

            RuleFor(x => x.Level).Generic(0, short.MaxValue, Lang.PriceLevelIsInvalid, nameof(Lang.PriceLevelIsInvalid));

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.ValuePrice).Generic(0, decimal.MaxValue, Lang.PriceValueIsInvalid, nameof(Lang.PriceValueIsInvalid));

            RuleFor(x => x.QuantityPrice).Generic(0, short.MaxValue, Lang.PriceAccordingToQuantityIsNotValid, nameof(Lang.PriceAccordingToQuantityIsNotValid));
        }
    }
}