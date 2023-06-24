using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class OperationTypeValidator : AbstractValidator<IOperationType>
    {
        public OperationTypeValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Name(1, 25);

            RuleFor(x => x.SubclassId).NotNull().WithMessage("SubclassId is not valid");

            RuleFor(x => x.Intials).NotNull().WithMessage(Lang.InitialsAreNotValid)
                                  .MinimumLength(1).WithMessage("Initials MinimumLength is 1")
                                  .MaximumLength(3).WithMessage("Initials MaximumLength is 3");
        }
    }
}