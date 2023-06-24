using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SaleDetailValidator : AbstractValidator<ISaleDetail>
    {
        public SaleDetailValidator()
        {
            RuleFor(x => x.ProductId).Generic(1, int.MaxValue, Lang.ProductIsInvalid, nameof(Lang.ProductIsInvalid));
            RuleFor(x => x.Quantity).Generic(0, decimal.MaxValue, Lang.QuantityIsNotValid, nameof(Lang.QuantityIsNotValid));
            RuleFor(x => x.NetPrice).Generic(0.001m, decimal.MaxValue, Lang.SalePriceIsInvalid, nameof(Lang.SalePriceIsInvalid));
        }
    }
}