using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SaleValidator : AbstractValidator<ISale>
    {
        public SaleValidator()
        {
            RuleFor(x => x.BoxId).Generic(1, int.MaxValue, Lang.BoxIdIsInvalid, nameof(Lang.BoxIdIsInvalid));
            RuleFor(x => x.ShopId).Generic(1, int.MaxValue, Lang.ShopIsInvalid, nameof(Lang.ShopIsInvalid));
            RuleFor(x => x.CompanyId).Generic(1, int.MaxValue, Lang.CompanyIdIsInvalid, nameof(Lang.CompanyIdIsInvalid));
            RuleFor(x => x.UserId).UserID();
            RuleFor(x => x.OperationTypeId).Generic(1, int.MaxValue, Lang.OperationTypeIsInvalid, nameof(Lang.OperationTypeIsInvalid));
            RuleFor(x => x.MoneyId).Generic(1, int.MaxValue, Lang.moneyIsInvalid, nameof(Lang.moneyIsInvalid));
            RuleFor(x => x.CustomerId).Generic(1, int.MaxValue, Lang.CustomerIsNotValid, nameof(Lang.CustomerIsNotValid));
            RuleFor(x => x.CustomerAccountId).Generic(1, int.MaxValue, Lang.CustomerAccountNumberIsInvalid, nameof(Lang.CustomerAccountNumberIsInvalid));
            RuleFor(x => x.EmployeeId).Generic(1, int.MaxValue, Lang.EmployeeIdIsNull, nameof(Lang.EmployeeIdIsNull));
            RuleFor(x => x.PersonId).Generic(1, int.MaxValue, Lang.PersonIdIsInvalid, nameof(Lang.PersonIdIsInvalid));
            RuleFor(x => x.SerialId).Generic(Lang.SerialCodeIsInvalid, nameof(Lang.SerialCodeIsInvalid));
        }
    }
}