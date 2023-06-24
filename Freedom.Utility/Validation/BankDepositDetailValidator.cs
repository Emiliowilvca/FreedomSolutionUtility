using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class BankDepositDetailValidator : AbstractValidator<IBankDepositDetail>
    {
        public BankDepositDetailValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.BankDepositId).Generic(0, int.MaxValue, "Deposit Id is Invalid", "");

            RuleFor(x => x.Amount).Generic(0, decimal.MaxValue, Lang.AmountIsInvalid, nameof(Lang.AmountIsInvalid));

            RuleFor(x => x.CheckNumber).Generic(1, long.MaxValue, Lang.CheckNumberIsInvalid, nameof(Lang.CheckNumberIsInvalid));

            RuleFor(x => x.CheckDate).Generic(Lang.BankCheckDateIsInvalid, nameof(Lang.BankCheckDateIsInvalid));

            RuleFor(x => x.Sender).Generic(1, 50, Lang.SenderIsInvalid, nameof(Lang.SenderIsInvalid));

            RuleFor(x => x.ConceptCheck).Generic(1, 50, Lang.ConceptIsInvalid, nameof(Lang.ConceptIsInvalid));

            RuleFor(x => x.BankName).Generic(1, 50, Lang.BankNameIsInvalid, nameof(Lang.BankNameIsInvalid));
        }
    }
}