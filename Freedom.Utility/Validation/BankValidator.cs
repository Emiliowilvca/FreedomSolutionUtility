using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class BankValidator : AbstractValidator<IBank>
    {
        public BankValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.Address).Address(1, 150);

            RuleFor(x => x.Phone).PhoneNumber(1, 15);

            RuleFor(x => x.Phone).PhoneNumber(1, 15);

            RuleFor(x => x.Web).Generic(1, 100, Lang.WebIsInvalid, nameof(Lang.WebIsInvalid));

            RuleFor(x => x.Mail).EmailRequest();

            RuleFor(x => x.CityId).CityID();

            RuleFor(x => x.Manager).Generic(1, 50, Lang.ManagerIsInvalid, nameof(Lang.ManagerIsInvalid));
        }
    }
}