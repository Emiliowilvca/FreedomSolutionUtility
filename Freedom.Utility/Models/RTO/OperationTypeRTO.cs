using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class OperationTypeRTO : IOperationTypeRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SubclassId { get; set; }

        public string SubClassName { get; set; }

        public string Intials { get; set; }
    }
}