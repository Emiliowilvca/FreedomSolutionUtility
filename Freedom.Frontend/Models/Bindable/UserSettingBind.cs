using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class UserSettingBind : BindableBase, IUserSetting
    {
        private int _companyId;
        private int _boxId;
        private int _employeeId;
        private int _maxLevelPrice;
        private int _maxDiscountRate;
        private string _operationTypes;
        private string _groups;
        private string _zones;

        public int Id { get; set; }

        public Guid UserId { get; set; }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public int BoxId { get => _boxId; set => SetProperty(ref _boxId, value); }

        public int EmployeeId { get => _employeeId; set => SetProperty(ref _employeeId, value); }

        public int MaxLevelPrice { get => _maxLevelPrice; set => SetProperty(ref _maxLevelPrice, value); }

        public int MaxDiscountRate { get => _maxDiscountRate; set => SetProperty(ref _maxDiscountRate, value); }

        public string OperationTypes { get => _operationTypes; set => SetProperty(ref _operationTypes, value); }

        public string Groups { get => _groups; set => SetProperty(ref _groups, value); }

        public string Zones { get => _zones; set => SetProperty(ref _zones, value); }
    }
}