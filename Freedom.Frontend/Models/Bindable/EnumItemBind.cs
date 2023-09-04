using Freedom.Utility.Bindable;
  
namespace Freedom.Frontend.Models.Bindable
{
    public class EnumItemBind : BindableBase
    {
        private int _id;
        private string _description;

        public int Id { get => _id; set => SetProperty(ref _id, value); }

        public string Description { get => _description; set => SetProperty(ref _description, value); }
    }
}