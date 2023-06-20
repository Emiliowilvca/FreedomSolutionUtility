using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;

namespace Freedom.Frontend.Models.Bindable
{
    [Serializable]
    public class OperationTypeBind : BindableBase, IOperationType, ISelectable
    {
        private int _id;
        private int _companyId;
        private string _name;
        private int _subclassId;
        private bool _isSelected;
        private string _intials;
        private string _nameSET;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public int CompanyId { get => _companyId; set => SetProperty(ref _companyId, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int SubclassId { get => _subclassId; set => SetProperty(ref _subclassId, value); }

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public string Intials { get => _intials; set => SetProperty(ref _intials, value); }

        public string NameSET { get => _nameSET; set => SetProperty(ref _nameSET, value); }
    }
}