using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.InterfaceRTO
{
    public interface IBankExtractionRTO : IBankExtraction
    {
        string OpType { get; set; }
    }
}