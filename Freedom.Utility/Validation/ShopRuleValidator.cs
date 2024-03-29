﻿using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class ShopRuleValidator : AbstractValidator<IShopRule>
    {
        //TODO: Create Lang for error response
        public ShopRuleValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ShopId).ShopID();

            RuleFor(x => x.DecimalInStock).Generic(0, int.MaxValue, Lang.NumberOfDecimalsInStockIsInvalid, nameof(Lang.NumberOfDecimalsInStockIsInvalid));

            RuleFor(x => x.EncryptPriceKey).Generic(0, 20, Lang.SecretKeyForPriceIsNotValid, nameof(Lang.SecretKeyForPriceIsNotValid));

            RuleFor(x => x.InterestRateMonthly).Generic(0, 1000, Lang.InterestRateMonthlyIsInvalid, nameof(Lang.InterestRateMonthlyIsInvalid));

            RuleFor(x => x.InterestOnArrears).Generic(0, 1000, Lang.InterestOnArrearsIsInvalid, nameof(Lang.InterestOnArrearsIsInvalid));

            RuleFor(x => x.GrantDiscounts).Generic("GrantDiscounts is not valid", "");

            RuleFor(x => x.OperTypeCashPurchase).Generic(1, int.MaxValue, Lang.TypeOfOperationForPurchaseCashIsInvalid, nameof(Lang.TypeOfOperationForPurchaseCashIsInvalid));

            RuleFor(x => x.OperTypeCreditPurchase).Generic(1, int.MaxValue, Lang.TypeOfOperationForPurchaseOnCreditIsInvalid, nameof(Lang.TypeOfOperationForPurchaseOnCreditIsInvalid));

            RuleFor(x => x.PriceLevelDefault).Generic(0, int.MaxValue, Lang.PriceLevelDefaultIsInvalid, nameof(Lang.PriceLevelDefaultIsInvalid));
        }
    }
}