using Freedom.Utility.Models.InterfaceEntity;
using System;

namespace Freedom.Utility.Models.EntityDto
{
    [Serializable]
    public class VehicleDto : IEntity, IVehicle
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }
        
        public string Brand { get; set; }
        
        public string TruckModel { get; set; }
        
        public int Capacity { get; set; }
        
        public string Color { get; set; }
        
        public long InitialKm { get; set; }
        
        public string Patent { get; set; }
        
        public string ChassisNum { get; set; }
        
        public string EngineNum { get; set; }
        
        public int CarriageNum { get; set; }
        
        public string LoadType { get; set; }
        
        public string FuelType { get; set; }
        
        public string YearModel { get; set; }
    }
}