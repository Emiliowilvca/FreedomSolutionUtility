using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SaleDetailJsonValidator : AbstractValidator<ISaleDetailJson>
    {
        public SaleDetailJsonValidator()
        {
            RuleFor(x => x.Code).Generic(0, 20, Lang.ProductCodeIsInvalid, nameof(Lang.ProductCodeIsInvalid));

            RuleFor(x => x.Description).Generic(0, 50, Lang.ProductNameIsInvalid, nameof(Lang.ProductNameIsInvalid));

            RuleFor(x => x.Quantity).Generic(0, decimal.MaxValue, Lang.QuantityIsNotValid, nameof(Lang.QuantityIsNotValid));

            RuleFor(x => x.NetPrice).Generic(0, decimal.MaxValue, Lang.QuantityIsNotValid, nameof(Lang.QuantityIsNotValid));
        }
    }
}