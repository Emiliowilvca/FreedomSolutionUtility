using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.AllPurpose
{
    public class DeadlineType : BindableBase
    {
        private int _id;
        private string _keyLang;
        private string _name;
        private int _dayValue;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string keyLang { get => _keyLang; set => SetProperty(ref _keyLang, value); }

        public string Name { get => _name; set => SetProperty(ref _name, value); }

        public int DayValue { get => _dayValue; set => SetProperty(ref _dayValue, value); }
    }
}