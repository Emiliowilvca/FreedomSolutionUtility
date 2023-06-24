using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class VourcherTypeValidator : AbstractValidator<IVourcherType>
    {
        public VourcherTypeValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.CodeSET).Name(1, 50);

            RuleFor(x => x.NameSET).Name(1, 50);
        }
    }
}