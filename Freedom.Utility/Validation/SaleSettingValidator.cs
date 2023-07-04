using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SaleSettingValidator : AbstractValidator<ISaleSetting>
    {
        public SaleSettingValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.ShopId).ShopID();

            RuleFor(x => x.PersonId).Generic(1, int.MaxValue, Lang.PersonIdIsInvalid, nameof(Lang.PersonIdIsInvalid));

            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));

            RuleFor(x => x.CustomerAccountId).Generic(1, int.MaxValue, Lang.CustomerAccountIsInvalid, nameof(Lang.CustomerAccountIsInvalid));

            RuleFor(x => x.OperTypeCashSale).Generic(1, int.MaxValue, Lang.TypeOfOperationForSaleCashIsInvalid, nameof(Lang.TypeOfOperationForSaleCashIsInvalid));

            RuleFor(x => x.OperTypeCreditSale).Generic(1, int.MaxValue, Lang.TypeOfOperationForSaleOnCreditIsInvalid, nameof(Lang.TypeOfOperationForSaleOnCreditIsInvalid));

            RuleFor(x => x.OperTypeCashSale).Generic(1, int.MaxValue, Lang.OperationTypeIsInvalid, nameof(Lang.OperationTypeIsInvalid));

            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));

            RuleFor(x => x.ForceSaleIfStockIsZero).Generic("ForceSaleIfStockIsZero is not valid", "");

            RuleFor(x => x.MaxItemInSale).Generic(0, int.MaxValue, Lang.MaximumNumberOfItemsIsInvalid, nameof(Lang.MaximumNumberOfItemsIsInvalid));

            RuleFor(x => x.ModifyPriceInSales).Generic("OperTypeCashSale is not valid", "");

            RuleFor(x => x.MaxDiscountPercent).Generic(0, int.MaxValue, Lang.MaxDiscountPercentIsInvalid, nameof(Lang.MaxDiscountPercentIsInvalid));

            RuleFor(x => x.InstallmentPeriod).Generic(0, int.MaxValue, Lang.NumberOfInstallmentsInvalid, nameof(Lang.NumberOfInstallmentsInvalid));
        }
    }
}