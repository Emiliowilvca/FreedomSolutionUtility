using Freedom.Utility.Bindable;
using Freedom.Utility.Models.InterfaceEntity;
using Freedom.Utility.Models.InterfaceRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class VehicleINFO : BindableBase, IVehicleRTO, ISelectable
    {
        private int _id;
        private int _companyId;
        private string _brand;
        private string _truckModel;
        private int _capacity;
        private string _color;
        private long _initialKm;
        private string _patent;
        private string _chassisNum;
        private string _engineNum;
        private int _carriageNum;
        private string _loadType;
        private string _fuelType;
        private string _yearModel;
        private bool _isSelected;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Brand { get => _brand; set => SetProperty(ref _brand, value); }

        public string TruckModel { get => _truckModel; set => SetProperty(ref _truckModel, value); }

        public int Capacity { get => _capacity; set => SetProperty(ref _capacity, value); }

        public string Color { get => _color; set => SetProperty(ref _color, value); }

        public long InitialKm { get => _initialKm; set => SetProperty(ref _initialKm, value); }

        public string Patent { get => _patent; set => SetProperty(ref _patent, value); }

        public string ChassisNum { get => _chassisNum; set => SetProperty(ref _chassisNum, value); }

        public string EngineNum { get => _engineNum; set => SetProperty(ref _engineNum, value); }

        public int CarriageNum { get => _carriageNum; set => SetProperty(ref _carriageNum, value); }

        public string LoadType { get => _loadType; set => SetProperty(ref _loadType, value); }

        public string FuelType { get => _fuelType; set => SetProperty(ref _fuelType, value); }

        public string YearModel { get => _yearModel; set => SetProperty(ref _yearModel, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }
    }
}