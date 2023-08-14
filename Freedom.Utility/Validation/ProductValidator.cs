using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class ProductValidator : AbstractValidator<IProduct>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.BrandId).Generic(1, int.MaxValue, Lang.Brandisinvalid, nameof(Lang.Brandisinvalid));

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.GroupId).Generic(1, int.MaxValue, Lang.GroupIsInvalid, nameof(Lang.GroupIsInvalid));

            RuleFor(x => x.MeasureId).Generic(1, int.MaxValue, Lang.MeasureIsInvalid, nameof(Lang.MeasureIsInvalid));

            RuleFor(x => x.PackageId).Generic(1, int.MaxValue, Lang.PackagingIsInvalid, nameof(Lang.PackagingIsInvalid));

            RuleFor(x => x.PriorityId).Generic(1, int.MaxValue, Lang.PriorityIsInvalid, nameof(Lang.PriorityIsInvalid));

            RuleFor(x => x.SourceId).Generic(1, int.MaxValue, Lang.SourceProductIsInvalid, nameof(Lang.SourceProductIsInvalid));

            RuleFor(x => x.SubgroupId).Generic(1, int.MaxValue, Lang.SubGroupIsInvalid, nameof(Lang.SubGroupIsInvalid));

            RuleFor(x => x.Advantage).Generic(0, 256, Lang.AdvantageIsInvalid, nameof(Lang.AdvantageIsInvalid));

            RuleFor(x => x.Benefit).Generic(0, 256, Lang.BenefitIsInvalid, nameof(Lang.BenefitIsInvalid));

            RuleFor(x => x.Code).Generic(3, 20, Lang.ProductCodeIsInvalid, nameof(Lang.ProductCodeIsInvalid));

            RuleFor(x => x.CodeProvider).Generic(2, 20, Lang.ProductCodeProviderIsInvalid, nameof(Lang.ProductCodeProviderIsInvalid));

            RuleFor(x => x.Barcode).Generic(2, 20, Lang.barcodeIsNotValid, nameof(Lang.BarcodeIsInvalid));

            RuleFor(x => x.Name).Generic(3, 50, Lang.ProductNameIsInvalid, nameof(Lang.ProductNameIsInvalid));

            RuleFor(x => x.GenericName).Generic(2, 50, Lang.GenericNameIsInvalid, nameof(Lang.GenericNameIsInvalid));

            RuleFor(x => x.Feature).Generic(0, 256, Lang.FeatureIsInvalid, nameof(Lang.FeatureIsInvalid));

            RuleFor(x => x.IsActive).Generic(Lang.ActiveProductIsInvalid, nameof(Lang.ActiveProductIsInvalid));

            RuleFor(x => x.AlterStock).Generic(Lang.AlterStockIsInvalid, nameof(Lang.AlterStockIsInvalid));

            RuleFor(x => x.IsService).Generic(Lang.ProductServiceIsInvalid, nameof(Lang.ProductServiceIsInvalid));

            RuleFor(x => x.PayTax).Generic(Lang.TaxIsInvalid, nameof(Lang.TaxIsInvalid));

            RuleFor(x => x.ProCheck).Generic(Lang.ProductCheckIsInvalid, nameof(Lang.ProductCheckIsInvalid));

            RuleFor(x => x.Wholesaler).Generic(Lang.WholesaleIsInvalid, nameof(Lang.WholesaleIsInvalid));

            RuleFor(x => x.ComissionSale).Generic(0, decimal.MaxValue, Lang.CommissionSaleIsNotValid, nameof(Lang.CommissionSaleIsNotValid));

            RuleFor(x => x.MaxDiscount).Generic(0, decimal.MaxValue, Lang.MaxDiscountPercentIsInvalid, nameof(Lang.MaxDiscountPercentIsInvalid));

            RuleFor(x => x.QuantityBox).Generic(0, decimal.MaxValue, Lang.QuantityPerBoxIsInvalid, nameof(Lang.QuantityPerBox));

            RuleFor(x => x.StockMax).Generic(0, decimal.MaxValue, Lang.MaximumStockIsInvalid, nameof(Lang.MaximumStockIsInvalid));

            RuleFor(x => x.StockMin).Generic(0, decimal.MaxValue, Lang.MinimunStockIsInvalid, nameof(Lang.MinimunStockIsInvalid));

            RuleFor(x => x.TaxRate).Generic(0, decimal.MaxValue, Lang.TaxRateIsNotValid, nameof(Lang.TaxRateIsNotValid));

            RuleFor(x => x.Weight).Generic(0, decimal.MaxValue, Lang.WeightIsNotValid, nameof(Lang.WeightIsNotValid));
        }
    }
}