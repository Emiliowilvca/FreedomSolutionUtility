using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class WithholdingVouchersValidator : AbstractValidator<IWithholdingVouchers>
    {
        public WithholdingVouchersValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.TaxPayerStatusId).Generic(1, int.MaxValue, "Tax Payer Status Id is invalid", "");

            RuleFor(x => x.TaxType).Generic(1, 50, "TaxType is invalid", "");

            RuleFor(x => x.Code).Generic(1, int.MaxValue, "WithholdingVouchers code is invalid", "");

            RuleFor(x => x.Description).Generic(1, 800, "WithholdingVouchers code is invalid", "");
        }
    }
}