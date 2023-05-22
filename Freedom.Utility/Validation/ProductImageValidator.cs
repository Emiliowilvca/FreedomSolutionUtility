using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class ProductImageValidator : AbstractValidator<IProductImage>
    {
        public ProductImageValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.ProductId).Generic(1, int.MaxValue, Lang.ProductIsInvalid, nameof(Lang.ProductIsInvalid));

            RuleFor(x => x.PhotoIndex).Generic(1, int.MaxValue, Lang.ProductImageIndexIsInvalid, nameof(Lang.ProductImageIndexIsInvalid));

            RuleFor(x => x.PhotoId).Generic(Lang.ImageIdIsInvalid, nameof(Lang.ImageIdIsInvalid));

            RuleFor(x => x.PhotoObject).Generic(Lang.ImageIsInvalid, nameof(Lang.ImageIsInvalid));
        }
    }
}