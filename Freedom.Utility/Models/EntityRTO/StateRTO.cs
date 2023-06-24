using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class StateRTO : StateDto, IStateRTO
    {
        public string CountryName { get; set; }
    }
}