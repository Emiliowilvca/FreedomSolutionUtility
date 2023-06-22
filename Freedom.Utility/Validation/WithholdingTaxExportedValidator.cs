using FluentValidation;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class WithholdingTaxExportedValidator : AbstractValidator<IWithholdingTaxExported>
    {
        public WithholdingTaxExportedValidator()
        {
            RuleFor(x => x.Id).ID();
            RuleFor(x => x.CompanyId).CompanyID();
            RuleFor(x => x.PurchaseId).Generic(1, int.MaxValue, "Purchase Id is invalid", "");
            RuleFor(x => x.PurchaseWithHoldingTaxId).Generic(1, int.MaxValue, "WithHoldingTax Id is invalid", "");
        }
    }
}