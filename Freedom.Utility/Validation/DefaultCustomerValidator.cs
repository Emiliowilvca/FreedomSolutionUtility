using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class DefaultCustomerValidator : AbstractValidator<IDefaultCustomer>
    {
        public DefaultCustomerValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));

            RuleFor(x => x.CustomerAccountId).Generic(1, int.MaxValue, Lang.CustomerAccountNumberIsInvalid, nameof(Lang.CustomerAccountNumberIsInvalid));

            RuleFor(x => x.PersonId).Generic(1, int.MaxValue, Lang.PersonIdIsInvalid, nameof(Lang.PersonIdIsInvalid));

            RuleFor(x => x.MoneyId).MoneyID();
        }
    }
}