using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class AlterStockValidator : AbstractValidator<IAlterStock>
    {
        public AlterStockValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ProductId).ProviderID();

            RuleFor(x => x.ShopId).ShopID();

            RuleFor(x => x.UserId).UserID();

            RuleFor(x => x.OperationTypeId).OperationTypeID();

            RuleFor(x => x.SettingType).Generic(0, 12, Lang.SettingTypeStockIsInvalid, nameof(Lang.SettingTypeStockIsInvalid));

            RuleFor(x => x.Increase).Generic(decimal.MinValue, decimal.MaxValue, Lang.IncrementValueIsInvalid, nameof(Lang.IncrementValueIsInvalid));

            RuleFor(x => x.Decrease).Generic(decimal.MinValue, decimal.MaxValue, Lang.DecrementValueIsInvalid, nameof(Lang.DecrementValueIsInvalid));

            RuleFor(x => x.Manufactory).Generic(Lang.ManufactureDateIsInvalid, nameof(Lang.ManufactureDateIsInvalid));

            RuleFor(x => x.Expiration).Generic(Lang.ExpireDateIsInvalid, nameof(Lang.ExpireDateIsInvalid));

            RuleFor(x => x.Lote).Generic(1, 12, Lang.InvalidBatchRecord, nameof(Lang.InvalidBatchRecord));

            RuleFor(x => x.NoteReason).Generic(1, 30, Lang.TheReasonIsInvalid, nameof(Lang.TheReasonIsInvalid));

            RuleFor(x => x.AlterDate).Generic(Lang.DateIsInvalid, nameof(Lang.DateIsInvalid));

            RuleFor(x => x.SectorId).Generic(1, int.MaxValue, Lang.SectorProductIsInvalid, nameof(Lang.SectorProductIsInvalid));

            RuleFor(x => x.Column).Generic(0, int.MaxValue, Lang.ColumnIsInvalid, nameof(Lang.ColumnIsInvalid));

            RuleFor(x => x.Line).Generic(0, int.MaxValue, Lang.LineIsInvalid, nameof(Lang.LineIsInvalid));

            RuleFor(x => x.Shelving).Generic(0, int.MaxValue, Lang.ShelvingIsInvalid, nameof(Lang.ShelvingIsInvalid));

            RuleFor(x => x.Side).Generic(0, int.MaxValue, Lang.SideIsInvalid, nameof(Lang.SideIsInvalid));
        }
    }
}