using Freedom.Utility.Models.InterfaceRTO;
using Freedom.Utility.Models.EntityDto;

namespace Freedom.Utility.Models.EntityRTO
{
    public class OperationTypeRTO : OperationTypeDto, IOperationTypeRTO
    {
        public string SubClassName { get; set; }
    }
}