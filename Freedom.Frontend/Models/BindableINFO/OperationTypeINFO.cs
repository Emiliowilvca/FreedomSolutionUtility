using Freedom.Utility.Bindable;
using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Frontend.Models.BindableINFO
{
    public class OperationTypeINFO : BindableBase, IOperationTypeRTO, ISelectable
    {
        private bool _isSelected;
        private int _id;
        private string _name;
        private int _subclassId;
        private string _subClassName;
        private string _intials;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected, value); }

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int SubclassId { get => _subclassId; set => SetProperty(ref _subclassId, value); }

        public string SubClassName { get => _subClassName; set => SetProperty(ref _subClassName, value); }

        public string Intials { get => _intials; set => SetProperty(ref _intials, value); }

        public override void ResetEntity()
        {
            base.ResetEntity();
            Id = 0;
            Name = "";
            IsSelected = false;
            SubclassId = 0;
        }
    }
}