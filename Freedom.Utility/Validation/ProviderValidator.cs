using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class ProviderValidator : AbstractValidator<IProvider>
    {
        public ProviderValidator()
        {
            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.Address).Address(1, 50);

            RuleFor(x => x.Contact).ContactName(1, 30);

            RuleFor(x => x.Phone).PhoneNumber(1, 20);

            RuleFor(x => x.Email).EmailRequest();

            RuleFor(x => x.Ruc).Ruc(1, 20);

            RuleFor(x => x.ProviderTypeID).ProviderTypeID();

            RuleFor(x => x.CityId).CityID();

            RuleFor(x => x.PaymentTypeId).PaymentTypeID();

            RuleFor(x => x.Timbrado).Timbrado(1, 20);

            RuleFor(x => x.BankName).BankName(1, 50);

            RuleFor(x => x.BankAccountNum).AccountNum(1, 20);
        }
    }
}