using Freedom.Utility.Models.BaseRTO;

namespace Freedom.Utility.Models.RTO
{
    public class CarrierRTO : ICarrierRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Person { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }
    }
}