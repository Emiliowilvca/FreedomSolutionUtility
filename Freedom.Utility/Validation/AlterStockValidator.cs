using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
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

            RuleFor(x => x.Increase).Generic(decimal.MinValue, decimal.MaxValue, "", "");

            RuleFor(x => x.Decrease).Generic(decimal.MinValue, decimal.MaxValue, "", "");

            RuleFor(x => x.Manufactory).Generic("", "");

            RuleFor(x => x.Expiration).Generic(Lang.ExpireDateIsInvalid, nameof(Lang.ExpireDateIsInvalid));

            RuleFor(x => x.Lote).Generic(1, 12, "", "");

            RuleFor(x => x.NoteReason).Generic(1, 30, "", "");

            RuleFor(x => x.AlterDate).Generic(Lang.DateIsInvalid, nameof(Lang.DateIsInvalid));
        }
    }
}