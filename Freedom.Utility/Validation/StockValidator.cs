using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class StockValidator : AbstractValidator<IStock>
    {
        public StockValidator()
        {
            DateTime start = DateTime.Now.AddYears(-20);
            DateTime end = DateTime.Now.AddYears(20);

            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ProductId).Generic(0, int.MaxValue, Lang.ProductIsInvalid, nameof(Lang.ProductIsInvalid));

            RuleFor(x => x.ShopId).Generic(1, int.MaxValue, Lang.ShopIsInvalid, nameof(Lang.ShopIsInvalid));

            RuleFor(x => x.StockQuantity).Generic(decimal.MinValue, decimal.MaxValue, Lang.QuantityIsNotValid, nameof(Lang.QuantityIsNotValid));

            RuleFor(x => x.Lote).Generic(1, 12, Lang.BatchIsInvalid, nameof(Lang.BatchIsInvalid));

            RuleFor(x => x.SectorId).Generic(1, int.MaxValue, Lang.SectorProductIsInvalid, nameof(Lang.SectorProductIsInvalid));

            RuleFor(x => x.Column).Generic(0, int.MaxValue, Lang.ColumnIsInvalid, nameof(Lang.ColumnIsInvalid));

            RuleFor(x => x.Line).Generic(0, int.MaxValue, Lang.LineIsInvalid, nameof(Lang.LineIsInvalid));

            RuleFor(x => x.Shelving).Generic(0, int.MaxValue, Lang.ShelvingIsInvalid, nameof(Lang.ShelvingIsInvalid));

            RuleFor(x => x.Side).Generic(0, int.MaxValue, Lang.SideIsInvalid, nameof(Lang.SideIsInvalid));

            RuleFor(x => x.Expiration).Generic(Lang.ExpireDateIsInvalid, nameof(Lang.ExpireDateIsInvalid));

            RuleFor(x => x.Manufactory).Generic(Lang.ManufactureDateIsInvalid, nameof(Lang.ManufactureDateIsInvalid));
        }
    }
}