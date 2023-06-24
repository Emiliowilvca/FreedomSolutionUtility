using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class CustomerAccountValidator : AbstractValidator<ICustomerAccount>
    {
        public CustomerAccountValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.AccountNum).Generic(0, int.MaxValue, Lang.AccountNumberIsInvalid, nameof(Lang.AccountNumberIsInvalid));

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));

            RuleFor(x => x.MoneyId).Generic(1, int.MaxValue, Lang.moneyIsInvalid, nameof(Lang.moneyIsInvalid));

            RuleFor(x => x.ShopId).Generic(1, int.MaxValue, Lang.ShopIsInvalid, nameof(Lang.ShopIsInvalid));

            RuleFor(x => x.EmployeeId).Generic(1, int.MaxValue, Lang.EmployeeIdIsNull, nameof(Lang.EmployeeIdIsNull));

            RuleFor(x => x.CreditLimit).Generic(0, int.MaxValue, Lang.CreditLimitIsInvalid, nameof(Lang.CreditLimitIsInvalid));

            RuleFor(x => x.Active).Generic(Lang.CustomerActiveIsNotValid, nameof(Lang.CustomerActiveIsNotValid));

            RuleFor(x => x.StartDate).Generic(Lang.StartDateIsInvalid, nameof(Lang.StartDateIsInvalid));

            RuleFor(x => x.EndDate).Generic(Lang.EndDateIsInvalid, nameof(Lang.EndDateIsInvalid));
        }
    }
}