using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.ModelPlus;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Frontend.BindableModelValidation
{
    public class ProductBindValidator : AbstractValidator<IProductFull>
    {
        public ProductBindValidator()
        {
            RuleFor(x => x.IsActive).Generic(Lang.ActiveProductIsInvalid, nameof(Lang.ActiveProductIsInvalid));

            RuleFor(x => x.AlterStock).Generic(Lang.AlterStockIsInvalid, nameof(Lang.AlterStockIsInvalid));

            RuleFor(x => x.IsService).Generic(Lang.ProductServiceIsInvalid, nameof(Lang.ProductServiceIsInvalid));

            RuleFor(x => x.PayTax).Generic(Lang.TaxIsInvalid, nameof(Lang.TaxIsInvalid));

            RuleFor(x => x.ProCheck).Generic(Lang.ProductCheckIsInvalid, nameof(Lang.ProductCheckIsInvalid));

            RuleFor(x => x.Wholesaler).Generic(Lang.WholesaleIsInvalid, nameof(Lang.WholesaleIsInvalid));

            RuleFor(x => x.BrandId).Generic(1, int.MaxValue, Lang.TrademarkIsInvalid, nameof(Lang.TrademarkIsInvalid));

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.GroupId).Generic(1, int.MaxValue, Lang.GroupIsInvalid, nameof(Lang.GroupIsInvalid));

            RuleFor(x => x.Id).ID();

            RuleFor(x => x.MeasureId).Generic(1, int.MaxValue, Lang.MeasureIsInvalid, nameof(Lang.MeasureIsInvalid));

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.PackageId).Generic(1, int.MaxValue, Lang.PackagingIsInvalid, nameof(Lang.PackagingIsInvalid));

            RuleFor(x => x.PriorityId).Generic(1, int.MaxValue, Lang.PriorityIsInvalid, nameof(Lang.PriorityIsInvalid));

            RuleFor(x => x.SectorId).Generic(1, int.MaxValue, Lang.SectorProductIsInvalid, nameof(Lang.SectorProductIsInvalid));

            RuleFor(x => x.ShopId).Generic(1, int.MaxValue, Lang.ShopIsInvalid, nameof(Lang.ShopIsInvalid));

            RuleFor(x => x.SourceId).Generic(1, int.MaxValue, Lang.SourceProductIsInvalid, nameof(Lang.SourceProductIsInvalid));

            RuleFor(x => x.SubgroupId).Generic(1, int.MaxValue, Lang.SubGroupIsInvalid, nameof(Lang.SubGroupIsInvalid));

            RuleFor(x => x.Advantage).Generic(0, 256, Lang.AdvantageIsInvalid, nameof(Lang.AdvantageIsInvalid));

            RuleFor(x => x.Barcode).Generic(1, 20, Lang.barcodeIsNotValid, nameof(Lang.BarcodeIsInvalid));

            RuleFor(x => x.Benefit).Generic(0, 256, Lang.BenefitIsInvalid, nameof(Lang.BenefitIsInvalid));

            RuleFor(x => x.Code).Generic(1, 20, Lang.ProductCodeIsInvalid, nameof(Lang.ProductCodeIsInvalid));

            RuleFor(x => x.CodeProvider).Generic(1, 20, Lang.ProductCodeProviderIsInvalid, nameof(Lang.ProductCodeProviderIsInvalid));

            RuleFor(x => x.Column).Generic(0, int.MaxValue, Lang.ColumnIsInvalid, nameof(Lang.ColumnIsInvalid));

            RuleFor(x => x.Line).Generic(0, int.MaxValue, Lang.LineIsInvalid, nameof(Lang.LineIsInvalid));

            RuleFor(x => x.Shelving).Generic(0, int.MaxValue, Lang.ShelvingIsInvalid, nameof(Lang.ShelvingIsInvalid));

            RuleFor(x => x.Side).Generic(0, int.MaxValue, Lang.SideIsInvalid, nameof(Lang.SideIsInvalid));

            RuleFor(x => x.ComissionSale).Generic(0, decimal.MaxValue, Lang.CommissionSaleIsNotValid, nameof(Lang.CommissionSaleIsNotValid));

            RuleFor(x => x.CostPrice).Generic(0, decimal.MaxValue, Lang.CostPriceIsInvalid, nameof(Lang.CostPriceIsInvalid));

            RuleFor(x => x.Feature).Generic(0, 256, Lang.FeatureIsInvalid, nameof(Lang.FeatureIsInvalid));

            RuleFor(x => x.GenericName).Generic(1, 50, Lang.ProviderCode, nameof(Lang.About));

            RuleFor(x => x.MaxDiscount).Generic(0, decimal.MaxValue, Lang.MaxDiscountPercentIsInvalid, nameof(Lang.MaxDiscountPercentIsInvalid));

            RuleFor(x => x.Name).Generic(1, 50, Lang.ProductNameIsInvalid, nameof(Lang.ProductNameIsInvalid));

            RuleFor(x => x.Expiration).Generic(Lang.ExpireDateIsInvalid, nameof(Lang.ExpireDateIsInvalid));

            RuleFor(x => x.QuantityBox).Generic(0, decimal.MaxValue, Lang.QuantityPerBoxIsInvalid, nameof(Lang.QuantityPerBox));

            RuleFor(x => x.SalePrice).Generic(0, decimal.MaxValue, Lang.SalePriceIsInvalid, nameof(Lang.SalePriceIsInvalid));

            RuleFor(x => x.StockMax).Generic(0, decimal.MaxValue, Lang.MaximumStockIsInvalid, nameof(Lang.MaximumStockIsInvalid));

            RuleFor(x => x.StockMin).Generic(0, decimal.MaxValue, Lang.MinimunStockIsInvalid, nameof(Lang.MinimunStockIsInvalid));

            RuleFor(x => x.StockQuantity).Generic(0, decimal.MaxValue, Lang.QuantityStockIsInvalid, nameof(Lang.QuantityStockIsInvalid));

            RuleFor(x => x.TaxRate).Generic(0, decimal.MaxValue, Lang.TaxRateIsNotValid, nameof(Lang.TaxRateIsNotValid));

            RuleFor(x => x.Weight).Generic(0, decimal.MaxValue, Lang.WeightIsNotValid, nameof(Lang.WeightIsNotValid));
        }
    }
}