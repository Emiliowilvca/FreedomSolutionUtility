using Freedom.Utility.Models.BaseEntity;
using Freedom.Utility.Models.BaseRTO;
using System;

namespace Freedom.Utility.Models.RTO
{
    public class ProviderRTO : IEntity, IProviderRTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Ruc { get; set; }

        public string Timbrado { get; set; }

        public int CompanyId { get; set; }

        public string Address { get; set; }

        public int ProviderTypeID { get; set; }

        public int CityId { get; set; }

        public int PaymentTypeId { get; set; }

        public DateTime Authorization { get; set; }

        public DateTime Expiration { get; set; }

        public string BankName { get; set; }

        public string BankAccountNum { get; set; }

        public string CityName { get; set; }

        public string ProviderTypeName { get; set; }

        public string PaymentTypeName { get; set; }
    }
}