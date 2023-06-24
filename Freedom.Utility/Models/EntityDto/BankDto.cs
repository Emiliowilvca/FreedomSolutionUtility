using Freedom.Utility.Models.InterfaceEntity;

namespace Freedom.Utility.Models.EntityDto
{
    public class BankDto : IBank
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Web { get; set; }

        public string Mail { get; set; }

        public string Manager { get; set; }

        public int CityId { get; set; }

        public int CompanyId { get; set; }
    }
}