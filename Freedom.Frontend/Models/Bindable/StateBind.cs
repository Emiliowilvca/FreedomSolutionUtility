using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class StateBind : BindableBase, IState, ISelectable
    {
        private int _id;
        private string _stateName;
        private int _countryId;
        private int _companyId;
        private bool _isSelected;
        private string _countryName;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _stateName; set => SetProperty(ref _stateName, value); }

        public int CountryId { get => _countryId; set => SetProperty(ref _countryId, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public string CountryName { get => _countryName; set => SetProperty(ref _countryName, value); }
    }
}