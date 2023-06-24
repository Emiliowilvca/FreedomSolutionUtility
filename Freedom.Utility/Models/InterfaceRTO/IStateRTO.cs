using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IStateRTO : IState
    {
        string CountryName { get; set; }
    }
}