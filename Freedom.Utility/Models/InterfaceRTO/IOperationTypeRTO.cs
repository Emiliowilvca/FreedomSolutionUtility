using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IOperationTypeRTO : IOperationType
    {
        string SubClassName { get; set; }
    }
}