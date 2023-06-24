namespace Freedom.Utility.Models.InterfaceEntity
{
    public interface IVehicle
    {
        int Id { get; set; }

        int CompanyId { get; set; }

        string Brand { get; set; }

        string TruckModel { get; set; }

        int Capacity { get; set; }

        string Color { get; set; }

        long InitialKm { get; set; }

        string Patent { get; set; }

        string ChassisNum { get; set; }

        string EngineNum { get; set; }

        int CarriageNum { get; set; }

        string LoadType { get; set; }

        string FuelType { get; set; }

        string YearModel { get; set; }
    }
}