using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class BankExtractionValidator : AbstractValidator<IBankExtraction>
    {
        public BankExtractionValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.BankAccountId).Generic(1, int.MaxValue, Lang.BankAccountIsInvalid, nameof(Lang.BankAccountIsInvalid));

            RuleFor(x => x.BankId).Generic(1, int.MaxValue, Lang.BankIdIsInvalid, nameof(Lang.BankIdIsInvalid));

            RuleFor(x => x.IsDeferredCheck).Generic(Lang.DeferredCheckIsInvalid, nameof(Lang.DeferredCheckIsInvalid));

            RuleFor(x => x.UserId).UserID();

            RuleFor(x => x.OperationTypeId).OperationTypeID();

            RuleFor(x => x.PostedDate).Generic(Lang.PostedDateIsInvalid, nameof(Lang.PostedDateIsInvalid));

            RuleFor(x => x.PaymentDate).Generic(Lang.PaymentDateIsInvalid, nameof(Lang.PaymentDateIsInvalid));

            RuleFor(x => x.CheckNumber).Generic(1, long.MaxValue, Lang.CheckNumberIsInvalid, nameof(Lang.CheckNumberIsInvalid));

            RuleFor(x => x.Amount).Generic(0, decimal.MaxValue, Lang.AmountIsInvalid, nameof(Lang.AmountIsInvalid));

            RuleFor(x => x.Payee).Generic(1, 50, Lang.PayeeIsInvalid, nameof(Lang.PayeeIsInvalid));

            RuleFor(x => x.Concept).Generic(1, 50, Lang.ConceptIsInvalid, nameof(Lang.ConceptIsInvalid));

            RuleFor(x => x.Status).Status();
        }
    }
}