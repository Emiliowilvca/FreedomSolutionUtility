using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.Bindable
{
    public class WithholdingPercentVAT5Bind : BindableBase
    {
        private int _id;
        private string _name;
        private decimal _percentValue;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public decimal PercentValue { get => _percentValue; set => SetProperty(ref _percentValue, value); }
    }
}