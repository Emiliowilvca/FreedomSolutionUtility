using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class PurchaseDetailValidator : AbstractValidator<IPurchaseDetail>
    {
        public PurchaseDetailValidator()
        {
            RuleFor(x => x.ProductId).Generic(1, int.MaxValue, Lang.ProductIsInvalid, nameof(Lang.ProductIsInvalid));

            RuleFor(x => x.Quantity).Generic(0.001m, decimal.MaxValue, Lang.QuantityIsNotValid, nameof(Lang.QuantityIsNotValid));

            RuleFor(x => x.Price).Generic(0.001m, decimal.MaxValue, Lang.CostPriceIsInvalid, nameof(Lang.CostPriceIsInvalid));

            RuleFor(x => x.Manufactory).Generic(Lang.ManufactureDateIsInvalid, nameof(Lang.ManufactureDateIsInvalid));

            RuleFor(x => x.Expiration).Generic(Lang.ExpireDateIsInvalid, nameof(Lang.ExpireDateIsInvalid));

            RuleFor(x => x.TaxValue).Generic(0, decimal.MaxValue, Lang.TaxIsInvalid, nameof(Lang.TaxIsInvalid));

            RuleFor(x => x.TaxRate).Generic(0, decimal.MaxValue, Lang.TaxRateIsNotValid, nameof(Lang.TaxRateIsNotValid));
        }
    }
}