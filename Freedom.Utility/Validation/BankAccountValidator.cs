using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class BankAccountValidator : AbstractValidator<IBankAccount>
    {
        public BankAccountValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.BankId).Generic(1, int.MaxValue, Lang.BankIdIsInvalid, nameof(Lang.BankIdIsInvalid));

            RuleFor(x => x.BankAccountTypeId).Generic(1, int.MaxValue, Lang.BankAccountTypeIsInvalid, nameof(Lang.BankAccountTypeIsInvalid));

            RuleFor(x => x.AccountNum).Generic(1, 30, Lang.AccountNumberIsInvalid, nameof(Lang.AccountNumberIsInvalid));

            RuleFor(x => x.AccountHolder).Generic(1, 30, Lang.AccountHolderIsInvalid, nameof(Lang.AccountHolderIsInvalid));

            RuleFor(x => x.CreditOfficer).Generic(1, 50, Lang.CreditOfficerIsInvalid, nameof(Lang.CreditOfficerIsInvalid));

            RuleFor(x => x.Agency).Generic(1, 15, Lang.AgencyIsInvalid, nameof(Lang.AgencyIsInvalid));

            RuleFor(x => x.Phone).Generic(1, 15, Lang.PhoneNumber, nameof(Lang.PhoneNumber));
        }
    }
}