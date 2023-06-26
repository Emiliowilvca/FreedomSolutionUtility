using FluentValidation;
using Freedom.Frontend.Models.Bindable;
using Freedom.Utility.Langs;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Frontend.BindableModelValidation
{
    public class ShopRuleBindValidator : AbstractValidator<ShopRuleBind>
    {
        public ShopRuleBindValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ShopId).ShopID();

            RuleFor(x => x.DecimalInStock).Generic(0, 10, Lang.NumberOfDecimalsInStockIsInvalid, nameof(Lang.NumberOfDecimalsInStockIsInvalid));

            RuleFor(x => x.EncryptPriceKey).Generic(10, 10, Lang.SecretKeyForPriceIsNotValid, nameof(Lang.SecretKeyForPriceIsNotValid));

            RuleFor(x => x.InterestRateMonthly).Generic(0, 1000, Lang.InterestRateMonthlyIsInvalid, nameof(Lang.InterestRateMonthlyIsInvalid));

            RuleFor(x => x.MaxItemInSale).Generic(1, int.MaxValue, Lang.MaximumNumberOfItemsIsInvalid, nameof(Lang.MaximumNumberOfItemsIsInvalid));

            RuleFor(x => x.OperTypeCashPurchase).Generic(1, int.MaxValue, Lang.TypeOfOperationForPurchaseCashIsInvalid , nameof(Lang.TypeOfOperationForPurchaseCashIsInvalid));

            RuleFor(x => x.OperTypeCashSale).Generic(1, int.MaxValue, Lang.TypeOfOperationForSaleCashIsInvalid, nameof(Lang.TypeOfOperationForSaleCashIsInvalid));

            RuleFor(x => x.OperTypeCreditPurchase).Generic(1, int.MaxValue, Lang.TypeOfOperationForPurchaseOnCreditIsInvalid, nameof(Lang.TypeOfOperationForPurchaseOnCreditIsInvalid));

            RuleFor(x => x.OperTypeCreditSale).Generic(1, int.MaxValue, Lang.TypeOfOperationForSaleOnCreditIsInvalid, nameof(Lang.TypeOfOperationForSaleOnCreditIsInvalid));

            RuleFor(x => x.PriceLevelDefault).Generic(1, int.MaxValue, Lang.PriceLevelDefaultIsInvalid, nameof(Lang.PriceLevelDefaultIsInvalid));

            RuleFor(x => x.MaxDiscountPercent).Generic(0, int.MaxValue, Lang.MaxDiscountPercentIsInvalid, nameof(Lang.MaxDiscountPercentIsInvalid));

            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));
        }
    }
}