using FluentValidation;
using Freedom.Utility.Langs;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.ValidatorExtension;

namespace Freedom.Utility.Validation
{
    public class VehicleValidator : AbstractValidator<IVehicle>
    {
        public VehicleValidator()
        {
            RuleFor(x => x.Id).ID();

            RuleFor(x => x.CompanyId).CompanyID();

            RuleFor(x => x.Brand).Generic(1, 30, Lang.Brandisinvalid, nameof(Lang.Brandisinvalid));

            RuleFor(x => x.TruckModel).Generic(1, 30, Lang.Model_is_invalid, nameof(Lang.Model_is_invalid));

            RuleFor(x => x.Capacity).Generic(0, int.MaxValue, Lang.CapacityisInvalid, nameof(Lang.CapacityisInvalid));

            RuleFor(x => x.Color).Generic(1, 30, Lang.ColorIsInvalid, nameof(Lang.ColorIsInvalid));

            RuleFor(x => x.InitialKm).Generic(0, long.MaxValue, Lang.InitialKmIsInvalid, nameof(Lang.InitialKmIsInvalid));

            RuleFor(x => x.Patent).Generic(1, 30, Lang.PatentIsInvalid, nameof(Lang.PatentIsInvalid));

            RuleFor(x => x.ChassisNum).Generic(1, 30, Lang.ChassisNumberIsInvalid, nameof(Lang.ChassisNumberIsInvalid));

            RuleFor(x => x.EngineNum).Generic(1, 30, Lang.EngineNumberIsInvalid, nameof(Lang.EngineNumberIsInvalid));

            RuleFor(x => x.CarriageNum).Generic(1, int.MaxValue, Lang.CarriagenNumberIsInvalid, nameof(Lang.CarriagenNumberIsInvalid));

            RuleFor(x => x.FuelType).Generic(1, 30, Lang.FuelTypeIsInvalid, nameof(Lang.FuelTypeIsInvalid));

            RuleFor(x => x.YearModel).Generic(1, 10, Lang.YearModelIsInvalid, nameof(Lang.YearModelIsInvalid));

            RuleFor(x => x.LoadType).Generic(1, 30, Lang.LoadTypeIsInvalid, nameof(Lang.LoadTypeIsInvalid));
        }
    }
}