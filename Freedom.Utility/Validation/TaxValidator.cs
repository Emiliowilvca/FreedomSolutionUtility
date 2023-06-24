using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class TaxValidator : AbstractValidator<ITax>
    {
        public TaxValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.Name).Name(1, 20);

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.TaxRate).TaxRate();
        }
    }
}