using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class PosDocumentValidator : AbstractValidator<IPosDocument>
    {
        public PosDocumentValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Name).Generic(0, 50, Lang.NameIsInvalid, nameof(Lang.NameIsInvalid));
        }
    }
}