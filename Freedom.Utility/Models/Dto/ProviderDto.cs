using Freedom.Utility.Models.BaseEntity;
using System;

namespace Freedom.Utility.Models.Dto
{
    [Serializable]
    public class ProviderDto : IEntity, IProvider
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Ruc { get; set; }

        public int ProviderTypeID { get; set; }

        public int CityId { get; set; }

        public int PaymentTypeId { get; set; }

        public DateTime Authorization { get; set; }

        public DateTime Expiration { get; set; }

        public string Timbrado { get; set; }

        public string BankName { get; set; }

        public string BankAccountNum { get; set; }
    }
}