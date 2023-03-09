using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class CostPriceValidator : AbstractValidator<ICostPrice>
    {
        public CostPriceValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ProductId).Generic(0, int.MaxValue, Lang.ProductIsInvalid, nameof(Lang.ProductIsInvalid));

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.CostValue).Generic(0, decimal.MaxValue, Lang.PriceValueIsInvalid, nameof(Lang.PriceValueIsInvalid));
        }
    }
}