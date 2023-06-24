using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class CarrierValidator : AbstractValidator<ICarrier>
    {
        public CarrierValidator()
        {
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.Person).ContactName(1, 40);

            RuleFor(x => x.Address).Address(1, 50);

            RuleFor(x => x.Phone).PhoneNumber(1, 20);

            RuleFor(x => x.Mobile).MobileNumber(1, 20);
        }
    }
}