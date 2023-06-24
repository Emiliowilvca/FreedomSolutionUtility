using FluentValidation;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class PurchaseValidator : AbstractValidator<IPurchase>
    {
        public PurchaseValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.PurchaseDate).PurchaseDate();

            RuleFor(x => x.InvoiceNum).InvoiceNumber(1);

            RuleFor(x => x.ProviderId).ProviderID();

            RuleFor(x => x.OperationTypeId).OperationTypeID();

            RuleFor(x => x.MoneyId).MoneyID();

            RuleFor(x => x.ShopId).ShopID();

            RuleFor(x => x.BoxId).BoxID();

            RuleFor(x => x.CarrierId).CarrierID();

            RuleFor(x => x.TotalTax).TotalIva(0m);

            RuleFor(x => x.Total).TotalNeto(0m);

            RuleFor(x => x.Exchange).Exchange(0m);

            RuleFor(x => x.Status).Status();

            RuleFor(x => x.Note).Remark(0, 50);

            RuleFor(x => x.Timbrado).Timbrado(0, 20);
        }
    }
}