using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class SubGroupValidator : AbstractValidator<ISubGroup>
    {
        public SubGroupValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 50);

            RuleFor(x => x.GroupId).Generic(1, int.MaxValue, Lang.GroupIdIsInvalid, nameof(Lang.GroupIdIsInvalid));
        }
    }
}