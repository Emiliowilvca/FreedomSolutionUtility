using Freedom.Utility.Bindable;

namespace Freedom.Frontend.Models.AllPurpose
{
    public class ProductAttibute : BindableBase
    {
        private string _title;
        private string _description;

        public ProductAttibute(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get => _title; set => SetProperty(ref _title, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }
    }
}