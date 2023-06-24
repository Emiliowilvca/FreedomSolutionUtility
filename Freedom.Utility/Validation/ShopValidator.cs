using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class ShopValidator : AbstractValidator<IShop>
    {
        public ShopValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.Mail).EmailRequest();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.Phone).PhoneNumber(0, 15);

            RuleFor(x => x.Address).Address(1, 100);

            RuleFor(x => x.BranchManager).BranchManager(1, 50);

            RuleFor(x => x.CityId).CityID();

            RuleFor(x => x.CompanyId).CompanyID();
        }
    }
}