using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class PurchaseWithHoldingTaxValidator : AbstractValidator<IPurchaseWithHoldingTax>
    {
        public PurchaseWithHoldingTaxValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.PurchaseId).Generic(1, int.MaxValue, "PurchaseId is invalid", "error 01");

            RuleFor(x => x.DateRetention).Generic("Date Retention is invalid", "error 01");

            RuleFor(x => x.MoneyISO4217).Generic(1, 3, "MoneyISO4217 is not Valid", "error 01");

            RuleFor(x => x.Condition).Generic(1, 10, "Condition is not Valid", "error 01");

            RuleFor(x => x.TaxPayerStatus).Generic(1, 20, "TaxPayerStatus is not Valid", "error 01");

            RuleFor(x => x.TipoComprobanteId).Generic(1, int.MaxValue, "TipoComprobanteId is not Valid", "error 01");

            RuleFor(x => x.IsRetentionIVA).NotNull().WithMessage("IsRetentionIVA is not Valid").WithErrorCode("error 01");

            RuleFor(x => x.IsRetentionRenta).NotNull().WithMessage("IsRetentionRenta is not Valid").WithErrorCode("error 01");

            RuleFor(x => x.ConceptRetentionTaxIva).Generic(0, 10, "ConceptRetentionTaxIva is not Valid", "error 01");

            RuleFor(x => x.ConceptRetentionRenta).Generic(0, 50, "ConceptRetentionRenta is not Valid", "error 01");

            RuleFor(x => x.ChangeType).Generic(1m, decimal.MaxValue, "Change Type is not Valid", "error 01");

            RuleFor(x => x.TotalInvoice).Generic(0m, decimal.MaxValue, "TotalInvoice is not Valid", "error 01");

            RuleFor(x => x.TotalIva5).Generic(0m, decimal.MaxValue, "TotalIva5 is not Valid", "error 01");

            RuleFor(x => x.TotalIva5).Generic(0m, decimal.MaxValue, "TotalIva5 is not Valid", "error 01");

            RuleFor(x => x.TotalIva10).Generic(0m, decimal.MaxValue, "TotalIva10 is not Valid", "error 01");

            RuleFor(x => x.TotalExenta).Generic(0m, decimal.MaxValue, "TotalExenta is not Valid", "error 01");

            RuleFor(x => x.TaxIva5).Generic(0m, decimal.MaxValue, "TaxIva5 is not Valid", "error 01");

            RuleFor(x => x.TaxIva10).Generic(0m, decimal.MaxValue, "TaxIva10 is not Valid", "error 01");

            RuleFor(x => x.TaxTotal).Generic(0m, decimal.MaxValue, "TaxTotal is not Valid", "error 01");

            RuleFor(x => x.RetentionPercentIva5).Generic(0m, decimal.MaxValue, "RetentionPercentIva5 is not Valid", "error 01");

            RuleFor(x => x.RetentionPercentIva10).Generic(0m, decimal.MaxValue, "RetentionPercentIva10 is not Valid", "error 01");

            RuleFor(x => x.RetentionPercentRenta).Generic(0m, decimal.MaxValue, "RetentionPercentRenta is not Valid", "error 01");

            RuleFor(x => x.RetentionIva5).Generic(0m, decimal.MaxValue, "RetentionIva5 is not Valid", "error 01");

            RuleFor(x => x.RetentionIva10).Generic(0m, decimal.MaxValue, "RetentionIva10 is not Valid", "error 01");

            RuleFor(x => x.RetentionRenta).Generic(0m, decimal.MaxValue, "RetentionRenta is not Valid", "error 01");

            RuleFor(x => x.RetentionCabeza).Generic(0m, decimal.MaxValue, "RetentionCabeza is not Valid", "error 01");

            RuleFor(x => x.RetentionTonelada).Generic(0m, decimal.MaxValue, "RetentionTonelada is not Valid", "error 01");

            RuleFor(x => x.RetentionTotalGeneral).Generic(0.5m, decimal.MaxValue, Lang.TotalWithholdingIsInvalid,
                                                                nameof(Lang.TotalWithholdingIsInvalid));
        }
    }
}