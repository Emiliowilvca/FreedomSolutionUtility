using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class CustomerValidator : AbstractValidator<ICustomer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x=> x.CompanyId).CompanyID();
            RuleFor(x => x.FullName).Generic(1, 75, Lang.FullNameIsInvalid, nameof(Lang.FullNameIsInvalid));
            RuleFor(x => x.Address).Address(1, 100);
            RuleFor(x => x.TradeName).Generic(1, 25, Lang.TradeNameIsInvalid, nameof(Lang.TradeNameIsInvalid));
            RuleFor(x => x.Ruc).Ruc(1, 15);
            RuleFor(x => x.Telephone).PhoneNumber(1, 12);
            RuleFor(x => x.Mobile1).Generic(1, 12, Lang.mobileIsInvalid,nameof(Lang.mobileIsInvalid));
            RuleFor(x => x.Mobile2).Generic(1, 12, Lang.mobileIsInvalid, nameof(Lang.mobileIsInvalid));
            RuleFor(x => x.CityId).CityID();
            RuleFor(x => x.CategoryId).Generic(1, int.MaxValue, Lang.CategoryIsInvalid, nameof(Lang.CategoryIsInvalid));
            RuleFor(x => x.BranchId).Generic(1, int.MaxValue, Lang.WorkActivityIsInvalid, nameof(Lang.WorkActivityIsInvalid));
            RuleFor(x => x.RouteId).Generic(1, int.MaxValue, Lang.RouteIsInvalid, nameof(Lang.RouteIsInvalid));
            RuleFor(x => x.WorkPlace).Generic(1, 50, Lang.WorkspaceIsInvalid,nameof(Lang.WorkspaceIsInvalid));
            RuleFor(x => x.Partner).Generic(1, 25, Lang.PartnerIsInvalid,nameof(Lang.PartnerIsInvalid));
            RuleFor(x => x.PartnerCI).Generic(1, int.MaxValue, Lang.IdentityPartnerIsInvalid,nameof(Lang.IdentityPartnerIsInvalid));
            RuleFor(x => x.ResidenceDate).Generic("Residence Date Is Invalid", "");
            RuleFor(x => x.OwnHouse).Generic("OwnHouse is Invalid", "");
            RuleFor(x => x.SendMoneyColletor).Generic("SendMoneyCollector is Invalid", "");
            RuleFor(x => x.LendProducts).Generic("LendProducts is Invalid", "");
            RuleFor(x => x.Credit).Generic("GrantCredit is invalid", "");
            RuleFor(x => x.Workphone).Generic(1, 12, "Workphone is invalid", "");
            RuleFor(x => x.DateAdmin).Generic("Date Admin is Invalid", "");
            RuleFor(x => x.Email).EmailRequest();
            RuleFor(x => x.Goods).Generic(1, 100, "Goods is invalid", "");
            RuleFor(x => x.EmployementDate).Generic("Employement Date is invalid", "");
            RuleFor(x => x.BirthDate).Generic("BirthDate is invalid", "");
            RuleFor(x => (int)x.Gender).Generic(0, 2, "Gender is invalid", "");
            RuleFor(x => (int)x.Children).Generic(0, byte.MaxValue, "number of children", "");
            RuleFor(x => (int)x.PriceLevel).Generic(1, byte.MaxValue, Lang.PriceLevelIsInvalid, nameof(Lang.PriceLevelIsInvalid));
            RuleFor(x => x.MaxDiscount).Generic(0, int.MaxValue, Lang.DiscountIsNotValid, nameof(Lang.DiscountIsNotValid));
            RuleFor(x => x.Note).Generic(1, 250, "note is invalid", "");
        }
    }
}