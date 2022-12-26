using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class BankDepositValidator : AbstractValidator<IBankDeposit>
    {
        public BankDepositValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.UserId).UserID();

            RuleFor(x => x.TransactionDate).Generic(Lang.TransactionDateIsInvalid, nameof(Lang.TransactionDateIsInvalid));

            RuleFor(x => x.DepositNumber).Generic(0, long.MaxValue, Lang.DepositNumberIsInvalid, nameof(Lang.DepositNumberIsInvalid));

            RuleFor(x => x.BankAccountId).Generic(0, int.MaxValue, Lang.BankAccountIsInvalid, nameof(Lang.BankAccountIsInvalid));

            RuleFor(x => x.Concept).Generic(1, 50, Lang.ConceptIsInvalid, nameof(Lang.ConceptIsInvalid));

            RuleFor(x => x.TotalCash).Generic(0, decimal.MaxValue, Lang.CashAmountIsInvalid, nameof(Lang.CashAmountIsInvalid));

            RuleFor(x => x.TotalCheck).Generic(0, decimal.MaxValue, Lang.CheckAmountIsInvalid, nameof(Lang.CheckAmountIsInvalid));

            RuleFor(x => x.OperationTypeId).OperationTypeID();

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.Status).Status();
        }
    }
}