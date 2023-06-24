using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class PaymentTypeValidator : AbstractValidator<IPaymentType>
    {
        public PaymentTypeValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.CompanyId).CompanyID();
        }
    }
}